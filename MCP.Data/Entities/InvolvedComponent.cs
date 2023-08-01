namespace CED.Data.Entities
{
    public class InvolvedComponent
    {
        public Guid IcoId { get; set; }

        public byte[] IcoTimeStamp { get; set; } = null!;

        public Guid IcoInvolvedObjectId { get; set; }

        public DateTime IcoCreatedDate { get; set; }

        public string? IcoCreatedBy { get; set; }

        public DateTime IcoLastModifiedDate { get; set; }

        public string? IcoLastModifiedBy { get; set; }

        public virtual InvolvedObject IcoInvolvedObject { get; set; } = null!;
    }
}