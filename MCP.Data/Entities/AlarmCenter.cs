namespace CED.Data.Entities
{
    public class AlarmCenter
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

        public virtual OrganizationUnit Alc { get; set; } = null!;

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();

        public virtual ICollection<InsurerAlarmCenter> InsurerAlarmCenters { get; } = new List<InsurerAlarmCenter>();

        public virtual ICollection<LeasingCompanyAlarmCenter> LeasingCompanyAlarmCenters { get; } =
            new List<LeasingCompanyAlarmCenter>();

        public virtual ICollection<MandateAlarmCenter> MandateAlarmCenters { get; } = new List<MandateAlarmCenter>();
    }
}