namespace CED.Data.Entities
{
    public class ActivityOption
    {
        public Guid AoId { get; set; }

        public byte[] AoTimeStamp { get; set; } = null!;

        public string? AoCode { get; set; }

        public string? AoShortName { get; set; }

        public string AoLongName { get; set; } = null!;

        public bool AoInactive { get; set; }

        public Guid? AoLocalizableEntryId { get; set; }

        public DateTime AoCreatedDate { get; set; }

        public string? AoCreatedBy { get; set; }

        public DateTime AoLastModifiedDate { get; set; }

        public string? AoLastModifiedBy { get; set; }

        public Guid? AoActivityOptionTypeId { get; set; }

        public short? AoDisplayOrder { get; set; }

        public virtual ICollection<ActivityOptionRelation> ActivityOptionRelationAorChildActivityExecutions { get; } =
            new List<ActivityOptionRelation>();

        public virtual ICollection<ActivityOptionRelation> ActivityOptionRelationAorParentActivityExecutions { get; } =
            new List<ActivityOptionRelation>();

        public virtual ActivityOptionType? AoActivityOptionType { get; set; }

        public virtual LocalizableEntry? AoLocalizableEntry { get; set; }

        public virtual ICollection<ContractActivityOption> ContractActivityOptions { get; } =
            new List<ContractActivityOption>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<FeeSettlementLine> FeeSettlementLines { get; } = new List<FeeSettlementLine>();

        public virtual ICollection<ProductActivityOption> ProductActivityOptions { get; } =
            new List<ProductActivityOption>();

        public virtual ICollection<ProductExclusion> ProductExclusionPexActivityOptions { get; } =
            new List<ProductExclusion>();

        public virtual ICollection<ProductExclusion> ProductExclusionPexReportingFormActivityOptions { get; } =
            new List<ProductExclusion>();

        public virtual ICollection<WorkActivityOption> WorkActivityOptions { get; } = new List<WorkActivityOption>();
    }
}