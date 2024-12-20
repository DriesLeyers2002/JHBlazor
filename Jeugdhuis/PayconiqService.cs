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

    public class PayconiqService // QR code: https://portal.payconiq.com/qrcode?c=https%3A%2F%2Fpayconiq.com%2Fl%2F1%2F64da11a5a2324a46e890a945%2FPOS00001
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;
        public PayconiqService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.ext.payconiq.com/v3/payments"); // test
            //_httpClient.BaseAddress = new Uri("https://api.payconiq.com/v3/payments"); // prod
            _configuration = configuration;
        }

        public async Task<JsonObject> CreatePayment(double amount)
        {
            using var client = new HttpClient();

            // Define the API endpoint
            var requestUri = "https://api.payconiq.com/v3/payments/pos";
            var authToken = _configuration["Payconiq:AuthorizationToken"];

            var amountString = ((int)(amount * 100)).ToString();

            // Prepare the request payload
            var payload = new
            {
                amount = amountString,
                currency = "EUR",
                callbackUrl = "https://dummy.network/api/v1/orders/payconiq",
                //description = "Test payment 12345",
                //reference = "12345",
                posId = "POS00001",
                //bulkId = "Bulk-1-200",
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
            var jsonContent = new StringContent(
                System.Text.Json.JsonSerializer.Serialize(payload),
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
