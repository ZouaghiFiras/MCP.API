namespace CED.Data.Entities
{
    public class ClientInsuranceProduct
    {
        public Guid CipId { get; set; }

        public byte[] CipTimeStamp { get; set; } = null!;

        public Guid CipClientId { get; set; }

        public Guid CipInsuranceCoverageId { get; set; }

        public string CipInsuranceProductName { get; set; } = null!;

        public DateTime CipEffectiveDate { get; set; }

        public DateTime? CipTerminationDate { get; set; }

        public Guid? CipDebtorClientId { get; set; }

        public DateTime CipCreatedDate { get; set; }

        public string? CipCreatedBy { get; set; }

        public DateTime CipLastModifiedDate { get; set; }

        public string? CipLastModifiedBy { get; set; }

        public virtual Client CipClient { get; set; } = null!;

        public virtual Client? CipDebtorClient { get; set; }

        public virtual InsuranceCoverage CipInsuranceCoverage { get; set; } = null!;
    }
}