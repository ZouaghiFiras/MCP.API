namespace CED.Data.Entities
{
    public class InvoiceDeliveryMethod
    {
        public string IdmId { get; set; } = null!;

        public byte[] IdmTimeStamp { get; set; } = null!;

        public string IdmDescription { get; set; } = null!;

        public string IdmInvoiceDeliveryMethodTypeId { get; set; } = null!;

        public bool IdmInactive { get; set; }

        public Guid? IdmLocalizableEntryId { get; set; }

        public bool IdmIsCreditorDefault { get; set; }

        public bool IdmIsDebtorDefault { get; set; }

        public DateTime IdmCreatedDate { get; set; }

        public string? IdmCreatedBy { get; set; }

        public DateTime IdmLastModifiedDate { get; set; }

        public string? IdmLastModifiedBy { get; set; }

        public virtual ICollection<ClientInvoiceDeliveryMethod> ClientInvoiceDeliveryMethods { get; } =
            new List<ClientInvoiceDeliveryMethod>();

        public virtual ICollection<CostFeeSettlement> CostFeeSettlements { get; } = new List<CostFeeSettlement>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual ICollection<FeeSettlement> FeeSettlements { get; } = new List<FeeSettlement>();

        public virtual InvoiceDeliveryMethodType IdmInvoiceDeliveryMethodType { get; set; } = null!;

        public virtual LocalizableEntry? IdmLocalizableEntry { get; set; }

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SupplierInvoiceDeliveryMethod> SupplierInvoiceDeliveryMethods { get; } =
            new List<SupplierInvoiceDeliveryMethod>();
    }
}