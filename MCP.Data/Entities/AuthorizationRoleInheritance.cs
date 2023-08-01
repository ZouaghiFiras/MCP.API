namespace CED.Data.Entities
{
    public class AuthorizationRoleInheritance
    {
        public Guid AriId { get; set; }

        public byte[] AriTimeStamp { get; set; } = null!;

        public string AriAuthorizationGroupRoleId { get; set; } = null!;

        public string AriAuthorizationInheritsRoleId { get; set; } = null!;

        public bool AriOperationCreate { get; set; }

        public bool AriOperationRead { get; set; }

        public bool AriOperationUpdate { get; set; }

        public bool AriOperationDelete { get; set; }

        public bool? AriOperationExecute { get; set; }

        public DateTime AriEffectiveDate { get; set; }

        public DateTime? AriTerminationDate { get; set; }

        public DateTime AriCreatedDate { get; set; }

        public string? AriCreatedBy { get; set; }

        public DateTime AriLastModifiedDate { get; set; }

        public string? AriLastModifiedBy { get; set; }

        public virtual AuthorizationGroupRole AriAuthorizationGroupRole { get; set; } = null!;

        public virtual AuthorizationRole AriAuthorizationInheritsRole { get; set; } = null!;
    }
}