namespace CED.Data.Entities
{
    public class OrganizationLabelType1
    {
        public Guid OltId { get; set; }

        public byte[] OltTimeStamp { get; set; } = null!;

        public string OltCode { get; set; } = null!;

        public string? OltShortName { get; set; }

        public string OltLongName { get; set; } = null!;

        public bool OltInactive { get; set; }

        public Guid? OltLocalizableEntryId { get; set; }

        public DateTime OltCreatedDate { get; set; }

        public string? OltCreatedBy { get; set; }

        public DateTime OltLastModifiedDate { get; set; }

        public string? OltLastModifiedBy { get; set; }
    }
}