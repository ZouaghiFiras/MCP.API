namespace CED.Data.Entities
{
    public class DraftUpload
    {
        public Guid DruId { get; set; }

        public byte[] DruTimeStamp { get; set; } = null!;

        public byte[] DruImage { get; set; } = null!;

        public DateTime DruCreatedDate { get; set; }

        public string? DruCreatedBy { get; set; }

        public DateTime DruLastModifiedDate { get; set; }

        public string? DruLastModifiedBy { get; set; }
    }
}