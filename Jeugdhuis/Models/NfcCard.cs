namespace Jeugdhuis.Models
{
    public class NfcCard
    {
        public int Id { get; set; }
        public Guid CardId { get; set; }
        public User User { get; set; }
        public double Balance { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }

        public NfcCard(Guid cardId, User user)
        {
            CardId = cardId;
            User = user;
            ExpiryDate = new DateTime(DateTime.Now.Year, 12, 31, 23, 59, 59);
            IsActive = true;
        }

        public NfcCard() { }
    }
}
