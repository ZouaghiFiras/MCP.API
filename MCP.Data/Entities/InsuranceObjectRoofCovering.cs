namespace CED.Data.Entities
{
    public class InsuranceObjectRoofCovering
    {
        public Guid IorfId { get; set; }

        public byte[] IorfTimeStamp { get; set; } = null!;

        public Guid IorfInsuranceObjectId { get; set; }

        public Guid IorfRoofCoveringId { get; set; }

        public DateTime IorfCreatedDate { get; set; }

        public string? IorfCreatedBy { get; set; }

        public DateTime IorfLastModifiedDate { get; set; }

        public string? IorfLastModifiedBy { get; set; }

        public virtual InsuranceObject IorfInsuranceObject { get; set; } = null!;

        public virtual RoofCovering IorfRoofCovering { get; set; } = null!;
    }
}