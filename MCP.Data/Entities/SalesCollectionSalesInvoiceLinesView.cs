namespace CED.Data.Entities
{
    public class SalesCollectionSalesInvoiceLinesView
    {
        public Guid SalesInvoiceId { get; set; }

        public string SalesInvoiceNumber { get; set; } = null!;

        public int SalesInvoiceLineNumber { get; set; }

        public string SalesInvoiceType { get; set; } = null!;

        public DateTime SalesInvoiceDate { get; set; }

        public string? RoadAuthorityName { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime? IncidentDate { get; set; }

        public string LicensePlate { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string? IncidentRoadTypeId { get; set; }

        public string? IncidentRoadNumber { get; set; }

        public string? IncidentRoadDirection { get; set; }

        public string? IncidentRoadHectometerPost { get; set; }

        public string? IncidentRoadLane { get; set; }

        public string? IncidentStreetName { get; set; }

        public string? IncidentCity { get; set; }

        public string? IncidentCountryCode { get; set; }

        public string? IncidentCountryName { get; set; }

        public string? AgentName { get; set; }

        public string? ClientName { get; set; }

        public string? InsurerName { get; set; }

        public string? MandateName { get; set; }

        public string? LeasingCompanyName { get; set; }

        public string? SupplierName { get; set; }

        public decimal NetAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal GrossAmount { get; set; }

        public double TaxRate { get; set; }

        public DateTime? SalesInvoiceCollectableDate { get; set; }

        public Guid SalesCollectionId { get; set; }

        public bool SalesInvoiceLineIsFee { get; set; }

        public string? WorkActiityCode { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}