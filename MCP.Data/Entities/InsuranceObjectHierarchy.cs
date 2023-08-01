namespace CED.Data.Entities
{
    public class InsuranceObjectHierarchy
    {
        public Guid IohId { get; set; }

        public byte[] IohTimeStamp { get; set; } = null!;

        public Guid IohParentInsuranceObjectId { get; set; }

        public DateTime IohStartDate { get; set; }

        public DateTime IohEndDate { get; set; }

        public DateTime IohCreatedDate { get; set; }

        public string? IohCreatedBy { get; set; }

        public DateTime IohLastModifiedDate { get; set; }

        public string? IohLastModifiedBy { get; set; }

        public virtual InsuranceObject IohParentInsuranceObject { get; set; } = null!;
    }
}