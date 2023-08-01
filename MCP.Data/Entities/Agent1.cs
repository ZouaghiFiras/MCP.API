namespace CED.Data.Entities
{
    public class Agent1
    {
        public Guid AgId { get; set; }

        public byte[] AgTimeStamp { get; set; } = null!;

        public string? AgExternalCode { get; set; }

        public string? AgCultureCodePreferredLanguage { get; set; }

        public bool? AgInactive { get; set; }

        public DateTime AgCreatedDate { get; set; }

        public string? AgCreatedBy { get; set; }

        public DateTime AgLastModifiedDate { get; set; }

        public string? AgLastModifiedBy { get; set; }
    }
}