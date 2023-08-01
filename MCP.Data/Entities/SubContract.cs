namespace CED.Data.Entities
{
    public class SubContract
    {
        public Guid SncId { get; set; }

        public byte[] SncTimeStamp { get; set; } = null!;

        public int SncLineNumber { get; set; }

        public DateTime SncEffectiveDate { get; set; }

        public DateTime? SncTerminationDate { get; set; }

        public Guid SncMainContractId { get; set; }

        public Guid SncOwnerLegalEntityId { get; set; }

        public Guid? SncOwnerDepartmentId { get; set; }

        public Guid SncProductId { get; set; }

        public string SncCurrencyCode { get; set; } = null!;

        public DateTime SncCreatedDate { get; set; }

        public string? SncCreatedBy { get; set; }

        public DateTime SncLastModifiedDate { get; set; }

        public string? SncLastModifiedBy { get; set; }

        public virtual ICollection<ContractActivityExecution> ContractActivityExecutions { get; } =
            new List<ContractActivityExecution>();

        public virtual ICollection<ContractActivityOption> ContractActivityOptions { get; } =
            new List<ContractActivityOption>();

        public virtual ICollection<ContractInsuranceCoverage> ContractInsuranceCoverages { get; } =
            new List<ContractInsuranceCoverage>();

        public virtual ICollection<ContractInsuranceObject> ContractInsuranceObjects { get; } =
            new List<ContractInsuranceObject>();

        public virtual ICollection<ContractWorkActivity> ContractWorkActivities { get; } =
            new List<ContractWorkActivity>();

        public virtual ICollection<HandlingCountry> HandlingCountries { get; } = new List<HandlingCountry>();

        public virtual MainContract SncMainContract { get; set; } = null!;

        public virtual Department? SncOwnerDepartment { get; set; }

        public virtual LegalEntity SncOwnerLegalEntity { get; set; } = null!;

        public virtual Product SncProduct { get; set; } = null!;
    }
}