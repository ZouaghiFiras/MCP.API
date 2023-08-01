namespace CED.Data.Entities
{
    public class GreenCardOfficeCountry
    {
        public Guid GccId { get; set; }

        public byte[] GccTimeStamp { get; set; } = null!;

        public Guid GccGreenCardOfficeId { get; set; }

        public string GccCountryId { get; set; } = null!;

        public DateTime GccEffectiveDate { get; set; }

        public DateTime? GccTerminationDate { get; set; }

        public DateTime GccCreatedDate { get; set; }

        public string? GccCreatedBy { get; set; }

        public DateTime GccLastModifiedDate { get; set; }

        public string? GccLastModifiedBy { get; set; }

        public virtual Country GccCountry { get; set; } = null!;

        public virtual GreenCardOffice GccGreenCardOffice { get; set; } = null!;
    }
}