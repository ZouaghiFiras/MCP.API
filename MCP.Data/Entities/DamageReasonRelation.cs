namespace CED.Data.Entities
{
    public class DamageReasonRelation
    {
        public Guid DrhId { get; set; }

        public byte[] DrhTimeStamp { get; set; } = null!;

        public Guid DrhChildDamageReasonId { get; set; }

        public Guid DrhParentDamageReasonId { get; set; }

        public DateTime DrhStartDate { get; set; }

        public DateTime DrhEndDate { get; set; }

        public DateTime DrhCreatedDate { get; set; }

        public string? DrhCreatedBy { get; set; }

        public DateTime DrhLastModifiedDate { get; set; }

        public string? DrhLastModifiedBy { get; set; }

        public virtual DamageReason DrhChildDamageReason { get; set; } = null!;

        public virtual DamageReason DrhParentDamageReason { get; set; } = null!;
    }
}