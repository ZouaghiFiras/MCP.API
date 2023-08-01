namespace CED.Data.Entities
{
    public class VatNumberValidationSource
    {
        public Guid VvsId { get; set; }

        public byte[] VvsTimeStamp { get; set; } = null!;

        public short VvsCode { get; set; }

        public string VvsName { get; set; } = null!;

        public string VvsResource { get; set; } = null!;

        public DateTime VvsCreatedDate { get; set; }

        public string? VvsCreatedBy { get; set; }

        public DateTime VvsLastModifiedDate { get; set; }

        public string? VvsLastModifiedBy { get; set; }

        public virtual ICollection<VatNumberValidation> VatNumberValidations { get; } = new List<VatNumberValidation>();
    }
}