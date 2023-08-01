namespace CED.Data.Entities
{
    public class Client1
    {
        public Guid ClId { get; set; }

        public byte[] ClTimeStamp { get; set; } = null!;

        public string? ClExternalCode { get; set; }

        public string? ClCultureCodePreferredLanguage { get; set; }

        public bool? ClInactive { get; set; }

        public DateTime ClCreatedDate { get; set; }

        public string? ClCreatedBy { get; set; }

        public DateTime ClLastModifiedDate { get; set; }

        public string? ClLastModifiedBy { get; set; }
    }
}