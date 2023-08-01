namespace CED.Data.Entities
{
    public class TransferDebtor
    {
        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public short DebtorStatus { get; set; }

        public string? ErrorMessage { get; set; }
    }
}