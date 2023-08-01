namespace CED.Data.Entities
{
    public class PurchaseOrder
    {
        public Guid PohId { get; set; }

        public byte[] PohTimeStamp { get; set; } = null!;

        public string PohOrderNumber { get; set; } = null!;

        public DateTime PohOrderDate { get; set; }

        public string? PohDescription { get; set; }

        public string? PohYourReference { get; set; }

        public string? PohOurReference { get; set; }

        public bool PohIsCredit { get; set; }

        public Guid? PohDebitPurchaseOrderId { get; set; }

        public Guid PohSupplierId { get; set; }

        public Guid PohLegalEntityId { get; set; }

        public Guid PohDepartmentId { get; set; }

        public Guid? PohDeliveryAddressId { get; set; }

        public DateTime? PohExpectedDeliveryDate { get; set; }

        public decimal? PohGrossAmount { get; set; }

        public decimal? PohTaxAmount { get; set; }

        public decimal? PohTaxExemptedAmount { get; set; }

        public decimal? PohTaxReversedChargeAmount { get; set; }

        public decimal? PohTaxImportAmount { get; set; }

        public decimal? PohNetAmount { get; set; }

        public string? PohCurrencyCode { get; set; }

        public bool PohIsPrinted { get; set; }

        public bool PohIsImported { get; set; }

        public string? PohCultureCode { get; set; }

        public string? PohEntryNumber { get; set; }

        public string? PohEntrySystem { get; set; }

        public string? PohEntryBatch { get; set; }

        public Guid? PohEmployeeId { get; set; }

        public string? PohDossierNumber { get; set; }

        public Guid? PohDossierId { get; set; }

        public Guid? PohDossierAssignmentId { get; set; }

        public Guid? PohDossierPartyId { get; set; }

        public Guid? PohInvolvedObjectId { get; set; }

        public bool PohIsIntercompany { get; set; }

        public Guid? PohDocumentArchiveId { get; set; }

        public Guid? PohInvoiceToPayorId { get; set; }

        public Guid? PohInvoiceToPayorAddressId { get; set; }

        public Guid? PohAssistancePlanId { get; set; }

        public Guid? PohSubContractorId { get; set; }

        public DateTime PohCreatedDate { get; set; }

        public string? PohCreatedBy { get; set; }

        public DateTime PohLastModifiedDate { get; set; }

        public string? PohLastModifiedBy { get; set; }

        public Guid? PohCurrentStatusHistoryId { get; set; }

        public DateTime? PohCurrentStatusHistoryStartDate { get; set; }

        public string? PohCurrentStatusCode { get; set; }

        public string? PohTaxCountryCode { get; set; }

        public Guid? PohOrderDocumentId { get; set; }

        public Guid? PohWorkingOrderLineId { get; set; }

        public virtual ICollection<PurchaseOrder> InversePohDebitPurchaseOrder { get; } = new List<PurchaseOrder>();

        public virtual AssistancePlan? PohAssistancePlan { get; set; }

        public virtual PurchaseOrder? PohDebitPurchaseOrder { get; set; }

        public virtual Address? PohDeliveryAddress { get; set; }

        public virtual Department PohDepartment { get; set; } = null!;

        public virtual Dossier? PohDossier { get; set; }

        public virtual DossierAssignment? PohDossierAssignment { get; set; }

        public virtual DossierParty? PohDossierParty { get; set; }

        public virtual Employee? PohEmployee { get; set; }

        public virtual OrganizationUnit? PohInvoiceToPayor { get; set; }

        public virtual Address? PohInvoiceToPayorAddress { get; set; }

        public virtual InvolvedObject? PohInvolvedObject { get; set; }

        public virtual LegalEntity PohLegalEntity { get; set; } = null!;

        public virtual Document? PohOrderDocument { get; set; }

        public virtual Supplier? PohSubContractor { get; set; }

        public virtual Supplier PohSupplier { get; set; } = null!;

        public virtual WorkingOrderLine? PohWorkingOrderLine { get; set; }

        public virtual ICollection<PurchaseOrderAuthorization> PurchaseOrderAuthorizations { get; } =
            new List<PurchaseOrderAuthorization>();

        public virtual ICollection<PurchaseOrderConfirmation> PurchaseOrderConfirmations { get; } =
            new List<PurchaseOrderConfirmation>();

        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

        public virtual ICollection<PurchaseOrderStatusHistory> PurchaseOrderStatusHistories { get; } =
            new List<PurchaseOrderStatusHistory>();
    }
}