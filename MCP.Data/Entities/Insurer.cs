namespace CED.Data.Entities
{
    public class Insurer
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

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();

        public virtual ICollection<InsurerAlarmCenter> InsurerAlarmCenters { get; } = new List<InsurerAlarmCenter>();

        public virtual OrganizationUnit Isr { get; set; } = null!;
    }
}