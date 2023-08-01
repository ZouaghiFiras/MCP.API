namespace CED.Data.Entities
{
    public class InvolvedObjectDamageLocation
    {
        public Guid IolId { get; set; }

        public byte[] IolTimeStamp { get; set; } = null!;

        public Guid IolInvolvedObjectId { get; set; }

        public Guid IolDamageLocationId { get; set; }

        public int IolSequenceNumber { get; set; }

        public bool IolIsActive { get; set; }

        public DateTime IolCreatedDate { get; set; }

        public string? IolCreatedBy { get; set; }

        public DateTime IolLastModifiedDate { get; set; }

        public string? IolLastModifiedBy { get; set; }

        public virtual DamageLocation IolDamageLocation { get; set; } = null!;

        public virtual InvolvedObject IolInvolvedObject { get; set; } = null!;
    }
}