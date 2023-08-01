namespace CED.Data.Entities
{
    public class ProductDamageReason
    {
        public Guid PdrId { get; set; }

        public byte[] PdrTimeStamp { get; set; } = null!;

        public Guid PdrProductId { get; set; }

        public Guid PdrDamageReasonId { get; set; }

        public bool PdrInactive { get; set; }

        public DateTime PdrCreatedDate { get; set; }

        public string? PdrCreatedBy { get; set; }

        public DateTime PdrLastModifiedDate { get; set; }

        public string? PdrLastModifiedBy { get; set; }

        public virtual DamageReason PdrDamageReason { get; set; } = null!;

        public virtual Product PdrProduct { get; set; } = null!;
    }
}