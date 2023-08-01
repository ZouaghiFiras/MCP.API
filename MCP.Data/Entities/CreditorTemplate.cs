namespace CED.Data.Entities
{
    public class CreditorTemplate
    {
        public Guid CdtId { get; set; }

        public byte[] CdtTimeStamp { get; set; } = null!;

        public Guid CdtCreditorId { get; set; }

        public Guid? CdtSupplierId { get; set; }

        public Guid? CdtBusinessUnitId { get; set; }

        public Guid? CdtDepartmentId { get; set; }

        public Guid CdtTemplateId { get; set; }

        public string? CdtEntrySystem { get; set; }

        public DateTime CdtEffectiveDate { get; set; }

        public DateTime? CdtTerminationDate { get; set; }

        public DateTime CdtCreatedDate { get; set; }

        public string? CdtCreatedBy { get; set; }

        public DateTime CdtLastModifiedDate { get; set; }

        public string? CdtLastModifiedBy { get; set; }

        public virtual BusinessUnit? CdtBusinessUnit { get; set; }

        public virtual Creditor CdtCreditor { get; set; } = null!;

        public virtual Department? CdtDepartment { get; set; }

        public virtual Supplier? CdtSupplier { get; set; }

        public virtual Template CdtTemplate { get; set; } = null!;
    }
}