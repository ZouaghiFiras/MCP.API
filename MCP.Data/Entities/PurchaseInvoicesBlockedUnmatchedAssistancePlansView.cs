namespace CED.Data.Entities
{
    public class PurchaseInvoicesBlockedUnmatchedAssistancePlansView
    {
        public Guid Id { get; set; }

        public string Number { get; set; } = null!;

        public bool IsCredit { get; set; }

        public string? Description { get; set; }

        public string? YourReference { get; set; }

        public string? OurReference { get; set; }

        public string InvoiceTypeCode { get; set; } = null!;

        public DateTime InvoiceDate { get; set; }

        public int? Priority { get; set; }

        public string? SupplierInvoiceNumber { get; set; }

        public decimal GrossAmount { get; set; }

        public decimal TaxAmount { get; set; }

        public decimal NetAmount { get; set; }

        public string? CurrencyCode { get; set; }

        public DateTime? DueDate { get; set; }

        public bool IsImported { get; set; }

        public string? EntrySystem { get; set; }

        public string? EntryNumber { get; set; }

        public string? EntryBatch { get; set; }

        public Guid LegalEntityId { get; set; }

        public string LegalEntityCode { get; set; } = null!;

        public string CreditorNumber { get; set; } = null!;

        public string CreditorName { get; set; } = null!;

        public bool CreditorIsCompany { get; set; }

        public string? CreditorPhone { get; set; }

        public string? CreditorPhoneExt { get; set; }

        public string? CreditorFax { get; set; }

        public string? CreditorEmail { get; set; }

        public string? CreditorHomePage { get; set; }

        public string? CreditorVatNumber { get; set; }

        public string? CreditorChamberOfCommerceNumber { get; set; }

        public string? CreditorEntrySystem { get; set; }

        public string? CreditorEntryNumber { get; set; }

        public string? CreditorEntryBatch { get; set; }

        public string? CreditorIban { get; set; }

        public string? CreditorStreetName { get; set; }

        public string? CreditorHouseNo { get; set; }

        public string? CreditorHouseNoAddition { get; set; }

        public string? CreditorPostalCode { get; set; }

        public string? CreditorCity { get; set; }

        public string? CreditorProvince { get; set; }

        public string? CreditorCountryCode { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public bool PayorIsDossierParty { get; set; }

        public bool IsIntercompany { get; set; }

        public Guid ClientId { get; set; }

        public string? ClientName { get; set; }

        public string? Journal { get; set; }

        public string? LedgerAccount { get; set; }

        public Guid? CostCenterId { get; set; }

        public string? CostCenterCode { get; set; }

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public bool IsRecipientLegalEntity { get; set; }

        public string? RecipientName { get; set; }

        public string? PayeeName { get; set; }

        public string? PayeeStreetName { get; set; }

        public string? PayeeHouseNo { get; set; }

        public string? PayeeHouseNoAddition { get; set; }

        public string? PayeePostalCode { get; set; }

        public string? PayeeCity { get; set; }

        public string? PayeeProvince { get; set; }

        public string? PayeeCountryCode { get; set; }

        public string? PayeeAccountHolderName { get; set; }

        public string? PayeeAccountNumber { get; set; }

        public string? PayeeBankName { get; set; }

        public string? PayeeIban { get; set; }

        public string? PayeeBic { get; set; }

        public bool IsInvoice { get; set; }

        public string? CreditReason { get; set; }

        public string? PurchaseInvoiceStatusCode { get; set; }

        public string? PurchaseInvoiceStatusName { get; set; }

        public DateTime? PurchaseInvoiceStatusCreatedDate { get; set; }

        public Guid? AssistancePlanId { get; set; }

        public string AssistancePlanNumber { get; set; } = null!;

        public DateTime? SourceReceivedDate { get; set; }

        public string? SourceFrom { get; set; }

        public string? DossierTypeCode { get; set; }

        public string? DossierTypeName { get; set; }

        public bool IsMedicalDossier { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}