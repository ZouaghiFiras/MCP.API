namespace CED.Data.Entities
{
    public class ServiceHierarchy
    {
        public Guid SehId { get; set; }

        public byte[] SehTimeStamp { get; set; } = null!;

        public Guid SehChildId { get; set; }

        public Guid SehParentId { get; set; }

        public double SehRelationNumberUnits { get; set; }

        public double SehRelationDivider { get; set; }

        public double SehChildUnitPriceIndex { get; set; }

        public DateTime SehEffectiveDate { get; set; }

        public DateTime? SehTerminationDate { get; set; }

        public DateTime SehCreatedDate { get; set; }

        public string? SehCreatedBy { get; set; }

        public DateTime SehLastModifiedDate { get; set; }

        public string? SehLastModifiedBy { get; set; }

        public virtual Service SehChild { get; set; } = null!;

        public virtual Service SehParent { get; set; } = null!;
    }
}