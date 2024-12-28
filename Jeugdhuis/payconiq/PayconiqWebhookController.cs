using Jeugdhuis;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System.Text.Json;

[ApiController]
[Route("api/[controller]")]
public class PayconiqWebhookController : ControllerBase
{
    private readonly IHubContext<PaymentHub> _hubContext;

    public PayconiqWebhookController(IHubContext<PaymentHub> hubContext)
    {
        _hubContext = hubContext;
    }

    [HttpPost]
    public async Task<IActionResult> ReceivePaymentNotification([FromBody] PayconiqPaymentNotification payload)
    {
        Console.WriteLine(JsonSerializer.Serialize(payload));

        if (payload.Status != "SUCCEEDED")
        {
            return BadRequest("Payment not successful");
        }

        await ProcessPayment(payload);

        return Ok();
    }

    private async Task ProcessPayment(PayconiqPaymentNotification payload)
    {
        Console.WriteLine($"Payment {payload.PaymentId} succeeded for {payload.Amount} {payload.Currency}");
        await _hubContext.Clients.All.SendAsync("PaymentReceived", payload.PaymentId, payload.Amount);
    }
}

public class PayconiqPaymentNotification
{
    public string PaymentId { get; set; }
    public int TransferAmount { get; set; }
    public int TippingAmount { get; set; }
    public int Amount { get; set; }
    public int TotalAmount { get; set; }
    public string Description { get; set; }
    public DateTime CreatedAt { get; set; }
    public DateTime ExpireAt { get; set; }
    public DateTime? SucceededAt { get; set; }
    public string Status { get; set; }
    public PayconiqDebtor Debtor { get; set; }
    public string Currency { get; set; }
}

public class PayconiqDebtor
{
    public string Name { get; set; }
    public string Iban { get; set; }
}

public class PayconiqVoucherAmount
{
    public string VoucherProvider { get; set; }
    public string VoucherScheme { get; set; }
    public int Amount { get; set; }
}
