namespace CED.Data.Entities
{
    public class TimeSheetApproval
    {
        public Guid TspId { get; set; }

        public byte[] TspTimeStamp { get; set; } = null!;

        public Guid TspTimeSheetAuthorizationId { get; set; }

        public DateTime TspApprovalDate { get; set; }

        public bool TspIsApproved { get; set; }

        public string? TspComment { get; set; }

        public Guid TspEmployeeId { get; set; }

        public string TspAutorizationRoleId { get; set; } = null!;

        public DateTime TspCreatedDate { get; set; }

        public string? TspCreatedBy { get; set; }

        public DateTime TspLastModifiedDate { get; set; }

        public string? TspLastModifiedBy { get; set; }

        public virtual AuthorizationRole TspAutorizationRole { get; set; } = null!;

        public virtual Employee TspEmployee { get; set; } = null!;

        public virtual TimeSheetAuthorization TspTimeSheetAuthorization { get; set; } = null!;
    }
}