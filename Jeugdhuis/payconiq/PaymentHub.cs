namespace Jeugdhuis
{
    using Microsoft.AspNetCore.SignalR;

    public class PaymentHub : Hub
    {
        public async Task PaymentReceived(string paymentId, int amount)
        {
            await Clients.All.SendAsync("PaymentReceived", paymentId, amount);
        }
    }
}
