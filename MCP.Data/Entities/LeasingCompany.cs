namespace CED.Data.Entities
{
    public class LeasingCompany
    {
        public Guid LcId { get; set; }

        public byte[] LcTimeStamp { get; set; } = null!;

        public string? LcExternalCode { get; set; }

        public string? LcCultureCodePreferredLanguage { get; set; }

        public bool? LcInactive { get; set; }

        public DateTime LcCreatedDate { get; set; }

        public string? LcCreatedBy { get; set; }

        public DateTime LcLastModifiedDate { get; set; }

        public string? LcLastModifiedBy { get; set; }

        public virtual ICollection<InsurancePolicy> InsurancePolicies { get; } = new List<InsurancePolicy>();

        public virtual OrganizationUnit Lc { get; set; } = null!;

        public virtual ICollection<LeasingCompanyAlarmCenter> LeasingCompanyAlarmCenters { get; } =
            new List<LeasingCompanyAlarmCenter>();
    }
}