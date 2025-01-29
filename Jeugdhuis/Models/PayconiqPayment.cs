namespace Jeugdhuis.Models.PayconiqPayments
{
    // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
    public class Creditor
    {
        public string profileId { get; set; }
        public string merchantId { get; set; }
        public string name { get; set; }
        public string iban { get; set; }
        public string callbackUrl { get; set; }
    }

    public class Debtor
    {
        public string name { get; set; }
        public string iban { get; set; }
    }

    public class Deeplink
    {
        public string href { get; set; }
    }

    public class Detail
    {
        public string paymentId { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime expireAt { get; set; }
        public DateTime succeededAt { get; set; }
        public string currency { get; set; }
        public string status { get; set; }
        public Creditor creditor { get; set; }
        public Debtor debtor { get; set; }
        public int amount { get; set; }
        public int transferAmount { get; set; }
        public int tippingAmount { get; set; }
        public int totalAmount { get; set; }
        public string description { get; set; }
        public string message { get; set; }
        public string reference { get; set; }
        public string bulkId { get; set; }
        public Links _links { get; set; }
    }

    public class Links
    {
        public Self self { get; set; }
        public Deeplink deeplink { get; set; }
        public Qrcode qrcode { get; set; }
        public Refund refund { get; set; }
    }

    public class Qrcode
    {
        public string href { get; set; }
    }

    public class Refund
    {
        public string href { get; set; }
    }

    public class PayconiqPayments
    {
        public int size { get; set; }
        public int totalPages { get; set; }
        public int totalElements { get; set; }
        public int number { get; set; }
        public List<Detail> details { get; set; }
    }

    public class Self
    {
        public string href { get; set; }
    }
}
