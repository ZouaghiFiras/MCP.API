namespace CED.Data.Entities
{
    public class WorkActivity
    {
        public Guid WaId { get; set; }

        public byte[] WaTimeStamp { get; set; } = null!;

        public string WaCode { get; set; } = null!;

        public string? WaShortName { get; set; }

        public string WaLongName { get; set; } = null!;

        public Guid? WaActivityExecutionId { get; set; }

        public bool WaInactive { get; set; }

        public Guid? WaLocalizableEntryId { get; set; }

        public bool WaIsMain { get; set; }

        public DateTime WaCreatedDate { get; set; }

        public string? WaCreatedBy { get; set; }

        public DateTime WaLastModifiedDate { get; set; }

        public string? WaLastModifiedBy { get; set; }

        public bool WaIsClientTask { get; set; }

        public bool WaIsSupplierTask { get; set; }

        public bool WaIsEconomicLoss { get; set; }

        public bool WaIsCoverageRequired { get; set; }

        public bool? WaIsInvoiceable { get; set; }

        public bool? WaIsForIntake { get; set; }

        public bool WaIsResultingInPurchaseOrder { get; set; }

        public bool WaIsResultingInClaimReserve { get; set; }

        public bool WaIsResultingInReversePurchaseInvoiceBilling { get; set; }

        public bool? WaIsNotSpecific { get; set; }

        public bool WaIsGeneric { get; set; }

        public bool? WaIsNotUrgent { get; set; }

        public virtual ICollection<ContractWorkActivity> ContractWorkActivities { get; } =
            new List<ContractWorkActivity>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();

        public virtual ICollection<ProductWorkActivity> ProductWorkActivities { get; } =
            new List<ProductWorkActivity>();

        public virtual ICollection<SalesLedgerSetting> SalesLedgerSettings { get; } = new List<SalesLedgerSetting>();

        public virtual ActivityExecution? WaActivityExecution { get; set; }

        public virtual LocalizableEntry? WaLocalizableEntry { get; set; }

        public virtual ICollection<WorkActivityExecution> WorkActivityExecutions { get; } =
            new List<WorkActivityExecution>();

        public virtual ICollection<WorkActivityOption> WorkActivityOptions { get; } = new List<WorkActivityOption>();

        public virtual ICollection<WorkActivityRelation> WorkActivityRelationWahChildWorkActivities { get; } =
            new List<WorkActivityRelation>();

        public virtual ICollection<WorkActivityRelation> WorkActivityRelationWahParentWorkActivities { get; } =
            new List<WorkActivityRelation>();

        public virtual ICollection<WorkActivitySkill> WorkActivitySkills { get; } = new List<WorkActivitySkill>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLines { get; } = new List<WorkingOrderLine>();
    }
}