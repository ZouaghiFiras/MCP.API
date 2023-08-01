namespace CED.Data.Entities
{
    public class SalesInvoiceLinesReportView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public Guid SalesInvoiceId { get; set; }

        public int LineNumber { get; set; }

        public DateTime InvoiceDate { get; set; }

        public string InvoiceNumber { get; set; } = null!;

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public DateTime? IntakeDate { get; set; }

        public string? IncidentNumber { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? LicensePlate { get; set; }

        public DateTime? IncidentDate { get; set; }

        public string InsureeName { get; set; } = null!;

        public string? InsuranceCoverage { get; set; }

        public string? InsurerName { get; set; }

        public string? MandateName { get; set; }

        public string? AgentName { get; set; }

        public string ClientName { get; set; } = null!;

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public double TaxRate { get; set; }

        public decimal? Discount { get; set; }

        public bool IsFee { get; set; }

        public string? WorkActivityCode { get; set; }

        public string? WorkActivityName { get; set; }

        public string? ActivityOptionName { get; set; }

        public string? EntrySystem { get; set; }

        public bool? IsImdossier { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}