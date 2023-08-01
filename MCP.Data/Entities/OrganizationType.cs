﻿namespace CED.Data.Entities
{
    public class OrganizationType
    {
        public Guid OtId { get; set; }

        public byte[] OtTimeStamp { get; set; } = null!;

        public string OtCode { get; set; } = null!;

        public string? OtShortName { get; set; }

        public string OtLongName { get; set; } = null!;

        public bool OtInactive { get; set; }

        public Guid? OtLocalizableEntryId { get; set; }

        public DateTime OtCreatedDate { get; set; }

        public string? OtCreatedBy { get; set; }

        public DateTime OtLastModifiedDate { get; set; }

        public string? OtLastModifiedBy { get; set; }

        public virtual ICollection<OrganizationUnit> OrganizationUnits { get; } = new List<OrganizationUnit>();

        public virtual LocalizableEntry? OtLocalizableEntry { get; set; }
    }
}