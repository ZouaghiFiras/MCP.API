namespace CED.Data.Entities
{
    public class Supplier
    {
        public Guid SupId { get; set; }

        public byte[] SupTimeStamp { get; set; } = null!;

        public string? SupExternalCode { get; set; }

        public Guid? SupPartnerId { get; set; }

        public string? SupCultureCodePreferredLanguage { get; set; }

        public string? SupPaymentBatchEmail { get; set; }

        public bool? SupIsPreferredSupplier { get; set; }

        public string? SupCurrencyCode { get; set; }

        public bool? SupInactive { get; set; }

        public DateTime SupCreatedDate { get; set; }

        public string? SupCreatedBy { get; set; }

        public DateTime SupLastModifiedDate { get; set; }

        public string? SupLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlan> AssistancePlans { get; } = new List<AssistancePlan>();

        public virtual ICollection<ClientPreferredSupplier> ClientPreferredSuppliers { get; } =
            new List<ClientPreferredSupplier>();

        public virtual ICollection<CostSettlement> CostSettlements { get; } = new List<CostSettlement>();

        public virtual ICollection<CreditorTemplate> CreditorTemplates { get; } = new List<CreditorTemplate>();

        public virtual ICollection<Creditor> Creditors { get; } = new List<Creditor>();

        public virtual ICollection<LegalEntity> LegalEntities { get; } = new List<LegalEntity>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrderPohSubContractors { get; } = new List<PurchaseOrder>();

        public virtual ICollection<PurchaseOrder> PurchaseOrderPohSuppliers { get; } = new List<PurchaseOrder>();

        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; } = new List<PurchaseReceipt>();

        public virtual ICollection<PurchaseTaxCode> PurchaseTaxCodes { get; } = new List<PurchaseTaxCode>();

        public virtual OrganizationUnit Sup { get; set; } = null!;

        public virtual Partner? SupPartner { get; set; }

        public virtual ICollection<SupplierBrand> SupplierBrands { get; } = new List<SupplierBrand>();

        public virtual ICollection<SupplierInvoiceDeliveryMethod> SupplierInvoiceDeliveryMethods { get; } =
            new List<SupplierInvoiceDeliveryMethod>();

        public virtual ICollection<SupplierService> SupplierServices { get; } = new List<SupplierService>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLineWolSubContractors { get; } =
            new List<WorkingOrderLine>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLineWolSuppliers { get; } =
            new List<WorkingOrderLine>();
    }
}