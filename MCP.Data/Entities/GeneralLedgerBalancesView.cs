namespace CED.Data.Entities
{
    public class GeneralLedgerBalancesView
    {
        public string Id { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? ExactAdministration { get; set; }

        public string? ExactLedgerAccount { get; set; }

        public bool IsPrimaryProcess { get; set; }

        public bool IsSuspenseAccount { get; set; }

        public bool IsProfitLossAccount { get; set; }

        public int? NumberOfLines { get; set; }

        public decimal? TotalCreditValue { get; set; }

        public decimal? TotalDebitValue { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string LegalEntityName { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}