namespace CED.Data.Entities
{
    public class DamageReasonCause
    {
        public Guid DrcId { get; set; }

        public byte[] DrcTimeStamp { get; set; } = null!;

        public Guid DrcCauseId { get; set; }

        public Guid DrcMainReasonId { get; set; }

        public Guid? DrcSecondaryReasonId { get; set; }

        public Guid? DrcTertiaryReasonId { get; set; }

        public DateTime DrcCreatedDate { get; set; }

        public string? DrcCreatedBy { get; set; }

        public DateTime DrcLastModifiedDate { get; set; }

        public string? DrcLastModifiedBy { get; set; }

        public virtual DamageReason DrcCause { get; set; } = null!;

        public virtual DamageReason DrcMainReason { get; set; } = null!;

        public virtual DamageReason? DrcSecondaryReason { get; set; }

        public virtual DamageReason? DrcTertiaryReason { get; set; }
    }
}