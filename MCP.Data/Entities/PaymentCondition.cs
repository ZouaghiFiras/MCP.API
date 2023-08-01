namespace CED.Data.Entities
{
    public class PaymentCondition
    {
        public Guid PycId { get; set; }

        public byte[] PycTimeStamp { get; set; } = null!;

        public string PycCode { get; set; } = null!;

        public string? PycShortName { get; set; }

        public string PycLongName { get; set; } = null!;

        public int? PycDueDays { get; set; }

        public bool PycIsDueDateUntilEndOfMonth { get; set; }

        public bool PycIsCreditorDefault { get; set; }

        public bool PycIsDebtorDefault { get; set; }

        public bool PycInactive { get; set; }

        public Guid PvcLegalEntityId { get; set; }

        public DateTime PycCreatedDate { get; set; }

        public string? PycCreatedBy { get; set; }

        public DateTime PycLastModifiedDate { get; set; }

        public string? PycLastModifiedBy { get; set; }

        public virtual ICollection<LegalEntity> LegalEntities { get; } = new List<LegalEntity>();

        public virtual ICollection<OrganizationPaymentCondition> OrganizationPaymentConditions { get; } =
            new List<OrganizationPaymentCondition>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual LegalEntity PvcLegalEntity { get; set; } = null!;

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();
    }
}