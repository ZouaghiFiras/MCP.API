namespace CED.Data.Entities
{
    public class GreenCardOffice
    {
        public Guid GcoId { get; set; }

        public byte[] GcoTimeStamp { get; set; } = null!;

        public string? GcoCultureCodePreferredLanguage { get; set; }

        public bool? GcoInactive { get; set; }

        public DateTime GcoCreatedDate { get; set; }

        public string? GcoCreatedBy { get; set; }

        public DateTime GcoLastModifiedDate { get; set; }

        public string? GcoLastModifiedBy { get; set; }

        public virtual OrganizationUnit Gco { get; set; } = null!;

        public virtual ICollection<GreenCardOfficeCountry> GreenCardOfficeCountries { get; } =
            new List<GreenCardOfficeCountry>();
    }
}