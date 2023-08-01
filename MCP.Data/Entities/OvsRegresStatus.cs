namespace CED.Data.Entities
{
    public class OvsRegresStatus
    {
        public Guid OrsId { get; set; }

        public byte[] OrsTimeStamp { get; set; } = null!;

        public Guid OrsOvsRegresId { get; set; }

        public Guid OrsOvsStatusId { get; set; }

        public DateTime OrsRegistrationDate { get; set; }

        public int? OrsSequenceNumber { get; set; }

        public DateTime OrsCreatedDate { get; set; }

        public string? OrsCreatedBy { get; set; }

        public DateTime OrsLastModifiedDate { get; set; }

        public string? OrsLastModifiedBy { get; set; }

        public virtual OvsRegre OrsOvsRegres { get; set; } = null!;

        public virtual OvsStatus OrsOvsStatus { get; set; } = null!;
    }
}