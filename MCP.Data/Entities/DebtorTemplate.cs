namespace CED.Data.Entities
{
    public class DebtorTemplate
    {
        public Guid DbtId { get; set; }

        public byte[] DbtTimeStamp { get; set; } = null!;

        public Guid DbtDebtorId { get; set; }

        public Guid? DbtBusinessUnitId { get; set; }

        public Guid? DbtDepartmentId { get; set; }

        public Guid DbtTemplateId { get; set; }

        public string? DbtEntrySystem { get; set; }

        public DateTime DbtEffectiveDate { get; set; }

        public DateTime? DbtTerminationDate { get; set; }

        public DateTime DbtCreatedDate { get; set; }

        public string? DbtCreatedBy { get; set; }

        public DateTime DbtLastModifiedDate { get; set; }

        public string? DbtLastModifiedBy { get; set; }

        public string? DbtFormat { get; set; }

        public virtual BusinessUnit? DbtBusinessUnit { get; set; }

        public virtual Debtor DbtDebtor { get; set; } = null!;

        public virtual Department? DbtDepartment { get; set; }

        public virtual Template DbtTemplate { get; set; } = null!;
    }
}