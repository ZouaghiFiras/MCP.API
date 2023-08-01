namespace CED.Data.Entities
{
    public class IntakeMethodMapping
    {
        public Guid ImmId { get; set; }

        public string ImmProspectCode { get; set; } = null!;

        public string ImmEiscode { get; set; } = null!;

        public DateTime ImmCreatedDate { get; set; }

        public string? ImmCreatedBy { get; set; }

        public DateTime ImmLastModifiedDate { get; set; }

        public string? ImmLastModifiedBy { get; set; }

        public byte[] ImmTimeStamp { get; set; } = null!;
    }
}