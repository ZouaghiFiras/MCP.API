namespace CED.Data.Entities
{
    public class TimeSheet
    {
        public Guid TshId { get; set; }

        public byte[] TshTimeStamp { get; set; } = null!;

        public Guid TshDossierWorkActivityId { get; set; }

        public Guid TshExecutionEmployeeId { get; set; }

        public Guid? TshExecutionEmployeeSkillId { get; set; }

        public DateTime TshExecutionDate { get; set; }

        public string TshUnitOfMeasureId { get; set; } = null!;

        public decimal TshQuantity { get; set; }

        public decimal TshQuantityInvoiceable { get; set; }

        public string? TshNotInvoiceableReason { get; set; }

        public DateTime TshCreatedDate { get; set; }

        public string? TshCreatedBy { get; set; }

        public DateTime TshLastModifiedDate { get; set; }

        public string? TshLastModifiedBy { get; set; }

        public virtual ICollection<SalesOrderToTimeSheetMapping> SalesOrderToTimeSheetMappings { get; } =
            new List<SalesOrderToTimeSheetMapping>();

        public virtual ICollection<TimeSheetAuthorization> TimeSheetAuthorizations { get; } =
            new List<TimeSheetAuthorization>();

        public virtual ICollection<TimeSheetReasonHistory> TimeSheetReasonHistories { get; } =
            new List<TimeSheetReasonHistory>();

        public virtual DossierWorkActivity TshDossierWorkActivity { get; set; } = null!;

        public virtual Employee TshExecutionEmployee { get; set; } = null!;

        public virtual Skill? TshExecutionEmployeeSkill { get; set; }

        public virtual UnitOfMeasure TshUnitOfMeasure { get; set; } = null!;
    }
}