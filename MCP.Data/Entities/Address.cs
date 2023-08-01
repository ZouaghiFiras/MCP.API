namespace CED.Data.Entities
{
    public class Address
    {
        public Guid AdrId { get; set; }

        public byte[] AdrTimeStamp { get; set; } = null!;

        public string? AdrStreetName { get; set; }

        public string? AdrHouseNo { get; set; }

        public string? AdrHouseNoAddition { get; set; }

        public string? AdrPostalCode { get; set; }

        public string? AdrCity { get; set; }

        public string? AdrProvince { get; set; }

        public string AdrCountryCode { get; set; } = null!;

        public double? AdrLongitude { get; set; }

        public double? AdrLatitude { get; set; }

        public string? AdrFreeField1 { get; set; }

        public string? AdrFreeField2 { get; set; }

        public string? AdrFreeField3 { get; set; }

        public DateTime AdrCreatedDate { get; set; }

        public string? AdrCreatedBy { get; set; }

        public DateTime AdrLastModifiedDate { get; set; }

        public string? AdrLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlanLocation> AssistancePlanLocations { get; } =
            new List<AssistancePlanLocation>();

        public virtual ICollection<Creditor> Creditors { get; } = new List<Creditor>();

        public virtual ICollection<Debtor> Debtors { get; } = new List<Debtor>();

        public virtual ICollection<Office> Offices { get; } = new List<Office>();

        public virtual ICollection<OrganizationAddress> OrganizationAddresses { get; } =
            new List<OrganizationAddress>();

        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<PurchaseOrder> PurchaseOrderPohDeliveryAddresses { get; } =
            new List<PurchaseOrder>();

        public virtual ICollection<PurchaseOrder> PurchaseOrderPohInvoiceToPayorAddresses { get; } =
            new List<PurchaseOrder>();

        public virtual ICollection<RecoveryStatement> RecoveryStatementRcsInsuredPartyAddresses { get; } =
            new List<RecoveryStatement>();

        public virtual ICollection<RecoveryStatement> RecoveryStatementRcsInsuredPartyInsurerAddresses { get; } =
            new List<RecoveryStatement>();

        public virtual ICollection<RecoveryStatement> RecoveryStatementRcsLiablePartyAddresses { get; } =
            new List<RecoveryStatement>();

        public virtual ICollection<RecoveryStatement> RecoveryStatementRcsLiablePartyInsurerAddresses { get; } =
            new List<RecoveryStatement>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLineWolDeliveryAddresses { get; } =
            new List<WorkingOrderLine>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLineWolInvoiceToPayorAddresses { get; } =
            new List<WorkingOrderLine>();
    }
}