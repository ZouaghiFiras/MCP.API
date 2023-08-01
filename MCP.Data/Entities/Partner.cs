namespace CED.Data.Entities
{
    public class Partner
    {
        public Guid ParId { get; set; }

        public byte[] ParTimeStamp { get; set; } = null!;

        public string? ParExternalCode { get; set; }

        public string? ParCultureCodePreferredLanguage { get; set; }

        public bool? ParInactive { get; set; }

        public DateTime ParCreatedDate { get; set; }

        public string? ParCreatedBy { get; set; }

        public DateTime ParLastModifiedDate { get; set; }

        public string? ParLastModifiedBy { get; set; }

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual ICollection<HandlingCountry> HandlingCountries { get; } = new List<HandlingCountry>();

        public virtual OrganizationUnit Par { get; set; } = null!;

        public virtual ICollection<Supplier> Suppliers { get; } = new List<Supplier>();
    }
}