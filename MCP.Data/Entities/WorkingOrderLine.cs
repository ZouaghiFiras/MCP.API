namespace CED.Data.Entities
{
    public class WorkingOrderLine
    {
        public Guid WolId { get; set; }

        public byte[] WolTimeStamp { get; set; } = null!;

        public Guid WolWorkingOrderId { get; set; }

        public string? WolLineNumber { get; set; }

        public Guid? WolDossierWorkActivityId { get; set; }

        public Guid? WolTaskWorkActivityId { get; set; }

        public bool WolIsForProductSelection { get; set; }

        public bool? WolIsClosed { get; set; }

        public bool? WolIsManuallyAdded { get; set; }

        public Guid? WolDeliveryAddressId { get; set; }

        public Guid? WolParentId { get; set; }

        public DateTime? WolDueDate { get; set; }

        public Guid? WolSupplierId { get; set; }

        public Guid? WolInvoiceToPayorId { get; set; }

        public Guid? WolSubContractorId { get; set; }

        public Guid? WolInvoiceToPayorAddressId { get; set; }

        public DateTime WolCreatedDate { get; set; }

        public string? WolCreatedBy { get; set; }

        public DateTime WolLastModifiedDate { get; set; }

        public string? WolLastModifiedBy { get; set; }

        public string? WolYourReference { get; set; }

        public Guid? WolDossierPartyId { get; set; }

        public bool? WolIsPayorDossierParty { get; set; }

        public bool? WolIsExecuteVatdeductable { get; set; }

        public bool? WolIsOwnRisk { get; set; }

        public DateTime? WolDeliveryDate { get; set; }

        public string? WolCurrencyCode { get; set; }

        public bool? WolIsSubContractor { get; set; }

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<WorkingOrderLine> InverseWolParent { get; } = new List<WorkingOrderLine>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual Address? WolDeliveryAddress { get; set; }

        public virtual DossierParty? WolDossierParty { get; set; }

        public virtual DossierWorkActivity? WolDossierWorkActivity { get; set; }

        public virtual OrganizationUnit? WolInvoiceToPayor { get; set; }

        public virtual Address? WolInvoiceToPayorAddress { get; set; }

        public virtual WorkingOrderLine? WolParent { get; set; }

        public virtual Supplier? WolSubContractor { get; set; }

        public virtual Supplier? WolSupplier { get; set; }

        public virtual WorkActivity? WolTaskWorkActivity { get; set; }

        public virtual WorkingOrder WolWorkingOrder { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineAttachment> WorkingOrderLineAttachments { get; } =
            new List<WorkingOrderLineAttachment>();

        public virtual ICollection<WorkingOrderLineCorrectionAuthorization> WorkingOrderLineCorrectionAuthorizations
        {
            get;
        } = new List<WorkingOrderLineCorrectionAuthorization>();

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();

        public virtual WorkingOrderLineCurrentStatus? WorkingOrderLineCurrentStatus { get; set; }

        public virtual ICollection<WorkingOrderLineInvolvedObject> WorkingOrderLineInvolvedObjects { get; } =
            new List<WorkingOrderLineInvolvedObject>();

        public virtual ICollection<WorkingOrderLineIsExecuteVatDeductableHistory>
            WorkingOrderLineIsExecuteVatDeductableHistories { get; } =
            new List<WorkingOrderLineIsExecuteVatDeductableHistory>();

        public virtual ICollection<WorkingOrderLineIsOwnRiskHistory> WorkingOrderLineIsOwnRiskHistories { get; } =
            new List<WorkingOrderLineIsOwnRiskHistory>();

        public virtual ICollection<WorkingOrderLineLogHistory> WorkingOrderLineLogHistories { get; } =
            new List<WorkingOrderLineLogHistory>();

        public virtual ICollection<WorkingOrderLineNote> WorkingOrderLineNotes { get; } =
            new List<WorkingOrderLineNote>();

        public virtual ICollection<WorkingOrderLineOperationalStatusHistory>
            WorkingOrderLineOperationalStatusHistories { get; } = new List<WorkingOrderLineOperationalStatusHistory>();

        public virtual ICollection<WorkingOrderLineParty> WorkingOrderLineParties { get; } =
            new List<WorkingOrderLineParty>();

        public virtual ICollection<WorkingOrderLineStatusHistory> WorkingOrderLineStatusHistories { get; } =
            new List<WorkingOrderLineStatusHistory>();

        public virtual ICollection<WorkingOrderLineTime> WorkingOrderLineTimes { get; } =
            new List<WorkingOrderLineTime>();

        public virtual WorkingOrderLineTrigger? WorkingOrderLineTrigger { get; set; }
    }
}