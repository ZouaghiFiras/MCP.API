namespace CED.Data.Entities
{
    public class ProductInsuranceObject
    {
        public Guid PioId { get; set; }

        public byte[] PioTimeStamp { get; set; } = null!;

        public Guid PioProductId { get; set; }

        public Guid PioInsuranceObjectId { get; set; }

        public bool PioInactive { get; set; }

        public DateTime PioCreatedDate { get; set; }

        public string? PioCreatedBy { get; set; }

        public DateTime PioLastModifiedDate { get; set; }

        public string? PioLastModifiedBy { get; set; }

        public virtual InsuranceObject PioInsuranceObject { get; set; } = null!;

        public virtual Product PioProduct { get; set; } = null!;
    }
}