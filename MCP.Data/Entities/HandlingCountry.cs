namespace CED.Data.Entities
{
    public class HandlingCountry
    {
        public Guid HncId { get; set; }

        public byte[] HncTimeStamp { get; set; } = null!;

        public DateTime HncEffectiveDate { get; set; }

        public DateTime? HncTerminationDate { get; set; }

        public Guid HncSubContractId { get; set; }

        public string HncCountryCodeIso3 { get; set; } = null!;

        public string HncCurrencyCode { get; set; } = null!;

        public short? HncHandlingTypeId { get; set; }

        public Guid? HncLegalEntityId { get; set; }

        public Guid? HncDepartmentId { get; set; }

        public Guid? HncPartnerId { get; set; }

        public DateTime HncCreatedDate { get; set; }

        public string? HncCreatedBy { get; set; }

        public DateTime HncLastModifiedDate { get; set; }

        public string? HncLastModifiedBy { get; set; }

        public virtual Department? HncDepartment { get; set; }

        public virtual HandlingType? HncHandlingType { get; set; }

        public virtual LegalEntity? HncLegalEntity { get; set; }

        public virtual Partner? HncPartner { get; set; }

        public virtual SubContract HncSubContract { get; set; } = null!;
    }
}