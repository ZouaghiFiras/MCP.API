namespace CED.Data.Entities
{
    public class AuthorizationRoleType
    {
        public string ArtId { get; set; } = null!;

        public byte[] ArtTimeStamp { get; set; } = null!;

        public string? ArtAbbreviation { get; set; }

        public string ArtDescription { get; set; } = null!;

        public bool ArtInactive { get; set; }

        public Guid? ArtLocalizableEntryId { get; set; }

        public DateTime ArtCreatedDate { get; set; }

        public string? ArtCreatedBy { get; set; }

        public DateTime ArtLastModifiedDate { get; set; }

        public string? ArtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? ArtLocalizableEntry { get; set; }

        public virtual ICollection<AuthorizationRole> AuthorizationRoles { get; } = new List<AuthorizationRole>();
    }
}