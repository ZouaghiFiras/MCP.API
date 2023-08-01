namespace CED.Data.Entities
{
    public class TimeSheetAuthorization
    {
        public Guid TsuId { get; set; }

        public byte[] TsuTimeStamp { get; set; } = null!;

        public Guid TsuTimeSheetId { get; set; }

        public string TsuRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime TsuCreatedDate { get; set; }

        public string? TsuCreatedBy { get; set; }

        public DateTime TsuLastModifiedDate { get; set; }

        public string? TsuLastModifiedBy { get; set; }

        public virtual ICollection<TimeSheetApproval> TimeSheetApprovals { get; } = new List<TimeSheetApproval>();

        public virtual AuthorizationRole TsuRequiredAutorizationRole { get; set; } = null!;

        public virtual TimeSheet TsuTimeSheet { get; set; } = null!;
    }
}