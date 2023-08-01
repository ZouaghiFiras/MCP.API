namespace CED.Data.Entities
{
    public class Tenant
    {
        public Guid TenId { get; set; }

        public byte[] TenTimeStamp { get; set; } = null!;

        public string TenCode { get; set; } = null!;

        public string TenName { get; set; } = null!;

        public bool TenInactive { get; set; }

        public DateTime TenCreatedDate { get; set; }

        public string? TenCreatedBy { get; set; }

        public DateTime TenLastModifiedDate { get; set; }

        public string? TenLastModifiedBy { get; set; }

        public virtual ICollection<CostOfSale> CostOfSales { get; } = new List<CostOfSale>();

        public virtual ICollection<CreditTransfer> CreditTransfers { get; } = new List<CreditTransfer>();

        public virtual ICollection<Creditor> Creditors { get; } = new List<Creditor>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<RecoveryStatement> RecoveryStatements { get; } = new List<RecoveryStatement>();

        public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

        public virtual ICollection<SalesInvoice> SalesInvoices { get; } = new List<SalesInvoice>();

        public virtual ICollection<SalesOrder> SalesOrders { get; } = new List<SalesOrder>();
    }
}