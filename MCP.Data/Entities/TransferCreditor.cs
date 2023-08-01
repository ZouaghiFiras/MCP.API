namespace CED.Data.Entities
{
    public class TransferCreditor
    {
        public Guid CreditorId { get; set; }

        public string CreditorNumber { get; set; } = null!;

        public short CreditorStatus { get; set; }

        public string? ErrorMessage { get; set; }
    }
}