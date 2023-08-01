namespace CED.Data.Entities
{
    public class OrganizationCodeType1
    {
        public Guid OctId { get; set; }

        public byte[] OctTimeStamp { get; set; } = null!;

        public string OctCode { get; set; } = null!;

        public string? OctShortName { get; set; }

        public string OctLongName { get; set; } = null!;

        public bool OctInactive { get; set; }

        public Guid? OctLocalizableEntryId { get; set; }

        public DateTime OctCreatedDate { get; set; }

        public string? OctCreatedBy { get; set; }

        public DateTime OctLastModifiedDate { get; set; }

        public string? OctLastModifiedBy { get; set; }
    }
}