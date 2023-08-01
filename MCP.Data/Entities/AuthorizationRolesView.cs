namespace CED.Data.Entities
{
    public class AuthorizationRolesView
    {
        public string Id { get; set; } = null!;

        public string? AuthorizationRoleTypeId { get; set; }

        public bool IsGroupRole { get; set; }

        public bool IsMiddleOfficeRole { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}