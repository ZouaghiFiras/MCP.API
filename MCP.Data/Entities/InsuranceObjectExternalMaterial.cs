namespace CED.Data.Entities
{
    public class InsuranceObjectExternalMaterial
    {
        public Guid IoemId { get; set; }

        public byte[] IoemTimeStamp { get; set; } = null!;

        public Guid IoemInsuranceObjectId { get; set; }

        public Guid IoemExternalMaterialId { get; set; }

        public DateTime IoemCreatedDate { get; set; }

        public string? IoemCreatedBy { get; set; }

        public DateTime IoemLastModifiedDate { get; set; }

        public string? IoemLastModifiedBy { get; set; }

        public virtual ExternalMaterial IoemExternalMaterial { get; set; } = null!;

        public virtual InsuranceObject IoemInsuranceObject { get; set; } = null!;
    }
}