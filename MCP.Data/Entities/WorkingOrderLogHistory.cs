namespace CED.Data.Entities
{
    public class WorkingOrderLogHistory
    {
        public Guid WolId { get; set; }

        public byte[] WolTimeStamp { get; set; } = null!;

        public Guid WolWorkingOrderId { get; set; }

        public int WolLineNumber { get; set; }

        public Guid? WolRoleCodeId { get; set; }

        public Guid? WolLogHistoryTypeId { get; set; }

        public string? WolFreeText { get; set; }

        public DateTime WolCreatedDate { get; set; }

        public string? WolCreatedBy { get; set; }

        public DateTime WolLastModifiedDate { get; set; }

        public string? WolLastModifiedBy { get; set; }

        public virtual LogHistoryType? WolLogHistoryType { get; set; }

        public virtual RoleCode? WolRoleCode { get; set; }

        public virtual WorkingOrder WolWorkingOrder { get; set; } = null!;
    }
}