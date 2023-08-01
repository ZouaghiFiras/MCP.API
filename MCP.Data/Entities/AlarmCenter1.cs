namespace CED.Data.Entities
{
    public class AlarmCenter1
    {
        public Guid AlcId { get; set; }

        public byte[] AlcTimeStamp { get; set; } = null!;

        public string? AlcExternalCode { get; set; }

        public string? AlcCultureCodePreferredLanguage { get; set; }

        public bool? AlcInactive { get; set; }

        public DateTime AlcCreatedDate { get; set; }

        public string? AlcCreatedBy { get; set; }

        public DateTime AlcLastModifiedDate { get; set; }

        public string? AlcLastModifiedBy { get; set; }
    }
}