﻿namespace CED.Data.Entities
{
    public class OrganizationCode1
    {
        public Guid OucId { get; set; }

        public byte[] OucTimeStamp { get; set; } = null!;

        public Guid OucOrganizationUnitId { get; set; }

        public Guid OucOrganizationCodeTypeId { get; set; }

        public string OucCode { get; set; } = null!;

        public DateTime? OucValidFromDate { get; set; }

        public DateTime? OucValidUntilDate { get; set; }

        public DateTime OucCreatedDate { get; set; }

        public string? OucCreatedBy { get; set; }

        public DateTime OucLastModifiedDate { get; set; }

        public string? OucLastModifiedBy { get; set; }
    }
}