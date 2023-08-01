namespace CED.Data.Entities
{
    public class WorkingOrderNoteRole
    {
        public Guid WonrId { get; set; }

        public byte[] WonrTimeStamp { get; set; } = null!;

        public Guid WonrWorkingOrderNoteId { get; set; }

        public string WonrAuthorizationGroupRoleId { get; set; } = null!;

        public DateTime WonrCreatedDate { get; set; }

        public string? WonrCreatedBy { get; set; }

        public DateTime WonrLastModifiedDate { get; set; }

        public string? WonrLastModifiedBy { get; set; }

        public virtual AuthorizationGroupRole WonrAuthorizationGroupRole { get; set; } = null!;

        public virtual WorkingOrderNote WonrWorkingOrderNote { get; set; } = null!;
    }
}