namespace CED.Data.Entities
{
    public class GeneralLedgersView
    {
        public string Id { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public bool IsPrimaryProcess { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public int? NumberOfLines { get; set; }

        public decimal? TotalCreditValue { get; set; }

        public decimal? TotalDebitValue { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}