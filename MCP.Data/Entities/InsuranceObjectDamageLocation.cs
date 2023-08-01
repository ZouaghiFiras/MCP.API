namespace CED.Data.Entities
{
    public class InsuranceObjectDamageLocation
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public Guid ObjectId { get; set; }

        public Guid DamageLocationId { get; set; }

        public bool Inactive { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public virtual DamageLocation DamageLocation { get; set; } = null!;

        public virtual InsuranceObject Object { get; set; } = null!;
    }
}