namespace CED.Data.Entities
{
    public class VatNumberValidation
    {
        public Guid VnvId { get; set; }

        public byte[] VnvTimeStamp { get; set; } = null!;

        public string VnvVatNumber { get; set; } = null!;

        public string VnvCountryCode { get; set; } = null!;

        public DateTime VnvValidationDate { get; set; }

        public bool VnvIsValid { get; set; }

        public string VnvCompanyName { get; set; } = null!;

        public string? VnvFullAddress { get; set; }

        public Guid VnvVatnumberValidationSourceId { get; set; }

        public DateTime VnvCreatedDate { get; set; }

        public string? VnvCreatedBy { get; set; }

        public DateTime VnvLastModifiedDate { get; set; }

        public string? VnvLastModifiedBy { get; set; }

        public virtual VatNumberValidationSource VnvVatnumberValidationSource { get; set; } = null!;
    }
}