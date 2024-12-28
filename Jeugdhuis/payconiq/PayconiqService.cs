namespace Jeugdhuis
{
    using Azure.Core;
    using Microsoft.Extensions.Configuration;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Threading.Tasks;

    public class PayconiqService // QR code TEST: https://portal.payconiq.com/qrcode?c=https%3A%2F%2Fpayconiq.com%2Fl%2F1%2F64da11a5a2324a46e890a945%2FPOS00001
    {                            // QR code PROD: https://portal.payconiq.com/qrcode?c=https%3A%2F%2Fpayconiq.com%2Fl%2F1%2F652e8323c88feb02443989fc%2FPOS00001
                                 // test 2 idk    https://portal.payconiq.com/qrcode?c=https%3A%2F%2Fpayconiq.com%2Fl%2F1%2F64da118da2324a46e890a944%2FPOS00001
        private readonly IConfiguration _configuration;
        public PayconiqService(HttpClient httpClient, IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public async Task<JsonObject> CreatePayment(double amount)
        {
            using var client = new HttpClient();

            // Define the API endpoint
            //var requestUri = "https://api.ext.payconiq.com/v3/payments/pos"; // testing
            var requestUri = "https://api.payconiq.com/v3/payments/pos";
            var authToken = _configuration["Payconiq:AuthorizationToken"];

            var amountString = ((int)(amount * 100)).ToString();

            // Prepare the request payload
            var payload = new
            {
                amount = amountString,
                currency = "EUR",
                callbackUrl = "https://2363-81-82-63-164.ngrok-free.app/api/PayconiqWebhook",
                //callbackUrl = "https://localhost:44300/api/PayconiqWebhook",
                description = $"Payment by Payconiq GO - JH De Caravan Application - {DateTime.Now}",
                posId = "POS00001",
                voucherEligibility = Array.Empty<string>(),
                //{
                //new
                //{
                //    voucherSchemes = new[] { "BEL_MEAL_VOUCHER" },
                //    amount = 99999
                //}
                //}
            };

            // Serialize the payload to JSON
            var jsonContent = new StringContent(JsonSerializer.Serialize(payload),
                Encoding.UTF8,
                "application/json"
            );

            // Configure the HTTP request
            var request = new HttpRequestMessage(HttpMethod.Post, requestUri)
            {
                Content = jsonContent
            };
            request.Headers.Add("Authorization", authToken);
            request.Headers.Add("Cache-Control", "no-cache");

            try
            {
                var response = await client.SendAsync(request);

                var res = await response.Content.ReadAsStringAsync();
                JsonObject parsedResponse = JsonSerializer.Deserialize<JsonObject>(res);
                return parsedResponse;
            }
            catch (HttpRequestException ex)
            {
                Console.WriteLine($"Request failed: {ex.Message}");
                throw;
            }
        }
    }
}
