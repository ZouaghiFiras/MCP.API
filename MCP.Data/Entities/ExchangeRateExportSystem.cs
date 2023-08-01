namespace CED.Data.Entities
{
    public class ExchangeRateExportSystem
    {
        public string EresId { get; set; } = null!;

        public byte[] EresTimeStamp { get; set; } = null!;

        public DateTime EresCreatedDate { get; set; }

        public string? EresCreatedBy { get; set; }

        public DateTime EresLastModifiedDate { get; set; }

        public string? EresLastModifiedBy { get; set; }

        public virtual ICollection<ExchangeRateExportSystemLine> ExchangeRateExportSystemLines { get; } =
            new List<ExchangeRateExportSystemLine>();

        public virtual ICollection<ExchangeRateExport> ExchangeRateExports { get; } = new List<ExchangeRateExport>();
    }
}