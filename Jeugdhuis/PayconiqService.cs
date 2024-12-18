namespace Jeugdhuis
{
    using Azure.Core;
    using System;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json;
    using System.Text.Json.Nodes;
    using System.Threading.Tasks;

    public class PayconiqService
    {
        private readonly HttpClient _httpClient;

        public PayconiqService(HttpClient httpClient)
        {
            _httpClient = httpClient;
            _httpClient.BaseAddress = new Uri("https://api.ext.payconiq.com/v3/payments");
        }

        public async Task<JsonObject> CreatePayment(decimal amount)
        {
            using var client = new HttpClient();

            // Define the API endpoint
            var requestUri = "https://api.ext.payconiq.com/v3/payments";

            var amountString = ((int)(amount * 100)).ToString();

            // Prepare the request payload
            var payload = new
            {
                amount = "99999",
                currency = "EUR",
                callbackUrl = "https://dummy.network/api/v1/orders/payconiq",
                description = "Test payment 12345",
                reference = "12345",
                bulkId = "Bulk-1-200",
                voucherEligibility = new[]
                {
                new
                {
                    voucherSchemes = new[] { "BEL_MEAL_VOUCHER" },
                    amount = 1013
                }
            }
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
            request.Headers.Add("Authorization", "Bearer be4352f1-94ad-44fc-94bd-e90249187808");
            request.Headers.Add("Cache-Control", "no-cache");

            try
            {
                var response = await client.SendAsync(request);
                response.EnsureSuccessStatusCode();

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
