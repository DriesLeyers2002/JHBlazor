﻿using PCSC;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Jeugdhuis.Models
{
    public class NfcService
    {
        private readonly SCardContext _context;
        private SCardReader? _reader;
        private string? _readerName;

        public event Action<string>? CardDetected;
        public event Action? CardRemoved;

        public NfcService()
        {
            _context = new SCardContext();
            _context.Establish(SCardScope.System);
        }

        public void StartListening()
        {
            _readerName = _context.GetReaders().FirstOrDefault();
            if (string.IsNullOrEmpty(_readerName))
            {
                throw new Exception("Geen NFC-lezer gevonden!");
            }

            _reader = new SCardReader(_context);

            Task.Run(() =>
            {
                while (true)
                {
                    var connection = _reader.Connect(_readerName, SCardShareMode.Shared, SCardProtocol.Any);
                    if (connection == SCardError.Success)
                    {
                        var uid = ReadCardUid();
                        if (!string.IsNullOrEmpty(uid))
                        {
                            CardDetected?.Invoke(uid);
                        }
                    }
                    else
                    {
                        CardRemoved?.Invoke();
                    }

                    Task.Delay(500).Wait();
                }
            });
        }

        private string ReadCardUid()
        {
            if (_reader == null || string.IsNullOrEmpty(_readerName))
            {
                throw new InvalidOperationException("Lezer is niet correct geconfigureerd.");
            }

            var sendBytes = new byte[] { 0xFF, 0xCA, 0x00, 0x00, 0x00 }; // APDU voor UID lezen
            var receiveBuffer = new byte[256];
            var receiveBufferLength = receiveBuffer.Length;
            var receivePci = new SCardPCI(); // Protocol control information

            var result = _reader.Transmit(
                SCardPCI.GetPci(_reader.ActiveProtocol),
                sendBytes,
                sendBytes.Length,
                receivePci,
                receiveBuffer,
                ref receiveBufferLength);

            if (result == SCardError.Success)
            {
                return BitConverter.ToString(receiveBuffer.Take(receiveBufferLength).ToArray());
            }

            return string.Empty;
        }
        

        public void StopListening()
        {
            _reader?.Disconnect(SCardReaderDisposition.Leave);
            _context?.Release();
        }
    }
}