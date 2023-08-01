namespace CED.Data.Entities
{
    public class SalesJournalEntryLinesExactView
    {
        public Guid Id { get; set; }

        public Guid JournalEntryId { get; set; }

        public int LineNumber { get; set; }

        public string? Description { get; set; }

        public string? ExactGeneralLedger { get; set; }

        public string? ExactJournal { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostUnitCode { get; set; }

        public double Quantity { get; set; }

        public decimal? GrossAmount { get; set; }

        public string? TaxCode { get; set; }

        public decimal? TaxAmount { get; set; }

        public decimal? NetAmount { get; set; }

        public bool? IsCredit { get; set; }

        public string? DossierNumber { get; set; }

        public decimal? ExchangeRate { get; set; }

        public string? CoverageProductTypeName { get; set; }

        public string? InsurancePolicyClientGroupName { get; set; }

        public string? InsurancePolicyClientName { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}