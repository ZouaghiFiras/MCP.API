namespace CED.Data.Entities
{
    public class SalesInvoicesCollectableView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public string? Description { get; set; }

        public DateTime InvoiceDate { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public decimal OpenAmount { get; set; }

        public decimal? SignedOpenAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public string? EntrySystem { get; set; }

        public string? OurReference { get; set; }

        public string? YourReference { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public Guid DebtorId { get; set; }

        public string DebtorNumber { get; set; } = null!;

        public string DebtorName { get; set; } = null!;

        public bool DebtorIsCompany { get; set; }

        public string? DebtorPhone { get; set; }

        public string? DebtorPhoneExt { get; set; }

        public string? DebtorFax { get; set; }

        public string? DebtorEmail { get; set; }

        public string? DebtorSalesCollectionEmail { get; set; }

        public string? DebtorHomePage { get; set; }

        public string? DebtorVatNumber { get; set; }

        public string? DebtorChamberOfCommerceNumber { get; set; }

        public string? DebtorEntrySystem { get; set; }

        public string? DebtorEntryNumber { get; set; }

        public string? DebtorStreetName { get; set; }

        public string? DebtorHouseNo { get; set; }

        public string? DebtorHouseNoAddition { get; set; }

        public string? DebtorPostalCode { get; set; }

        public string? DebtorCity { get; set; }

        public string? DebtorProvince { get; set; }

        public string? DebtorCountryCode { get; set; }

        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? AssignmentNumber { get; set; }

        public string? SalesCollectionNumber { get; set; }

        public bool HasSalesCollection { get; set; }

        public bool IsCollectable { get; set; }

        public DateTime? CollectableDate { get; set; }

        public string? InsureeName { get; set; }

        public DateTime? InsureeDateOfBirth { get; set; }

        public DateTime? IncidentDate { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? ClientReferenceNumber { get; set; }

        public string? ClientOrderNumber { get; set; }

        public string InsurerName { get; set; } = null!;

        public string? MandateName { get; set; }

        public string AgentName { get; set; } = null!;

        public string LeasingCompanyName { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public bool IsSelected { get; set; }

        public string? SelectedBy { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}