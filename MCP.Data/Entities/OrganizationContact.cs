namespace CED.Data.Entities
{
    public class OrganizationContact
    {
        public Guid OcsId { get; set; }

        public byte[] OcsTimeStamp { get; set; } = null!;

        public Guid OcsOrganizationUnitId { get; set; }

        public Guid OcsContactTypeId { get; set; }

        public string OcsContactValue { get; set; } = null!;

        public bool OcsIsPrimary { get; set; }

        public string? OcsNotes { get; set; }

        public DateTime OcsCreatedDate { get; set; }

        public string? OcsCreatedBy { get; set; }

        public DateTime OcsLastModifiedDate { get; set; }

        public string? OcsLastModifiedBy { get; set; }

        public virtual ContactType OcsContactType { get; set; } = null!;

        public virtual OrganizationUnit OcsOrganizationUnit { get; set; } = null!;
    }
}