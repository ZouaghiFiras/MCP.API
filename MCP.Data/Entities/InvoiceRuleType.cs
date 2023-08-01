namespace CED.Data.Entities
{
    public class InvoiceRuleType
    {
        public string IrtId { get; set; } = null!;

        public byte[] IrtTimeStamp { get; set; } = null!;

        public string IrtDescription { get; set; } = null!;

        public bool IrtInactive { get; set; }

        public Guid? IrtLocalizableEntryId { get; set; }

        public DateTime IrtCreatedDate { get; set; }

        public string? IrtCreatedBy { get; set; }

        public DateTime IrtLastModifiedDate { get; set; }

        public string? IrtLastModifiedBy { get; set; }

        public virtual ICollection<ClientInvoiceRuleMethod> ClientInvoiceRuleMethods { get; } =
            new List<ClientInvoiceRuleMethod>();

        public virtual ICollection<CostFeeSettlement> CostFeeSettlements { get; } = new List<CostFeeSettlement>();

        public virtual ICollection<FeeSettlement> FeeSettlements { get; } = new List<FeeSettlement>();

        public virtual LocalizableEntry? IrtLocalizableEntry { get; set; }
    }
}