namespace CED.Data.Entities
{
    public class Insurer1
    {
        public Guid IsrId { get; set; }

        public byte[] IsrTimeStamp { get; set; } = null!;

        public string? IsrExternalCode { get; set; }

        public string? IsrCultureCodePreferredLanguage { get; set; }

        public bool IsrChargedExpensesToBroker { get; set; }

        public bool IsrFeeToBroker { get; set; }

        public bool? IsrInactive { get; set; }

        public DateTime IsrCreatedDate { get; set; }

        public string? IsrCreatedBy { get; set; }

        public DateTime IsrLastModifiedDate { get; set; }

        public string? IsrLastModifiedBy { get; set; }
    }
}