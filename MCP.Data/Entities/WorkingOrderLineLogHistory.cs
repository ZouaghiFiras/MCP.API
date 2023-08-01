namespace CED.Data.Entities
{
    public class WorkingOrderLineLogHistory
    {
        public Guid WolhId { get; set; }

        public byte[] WolhTimeStamp { get; set; } = null!;

        public Guid WolhWorkingOrderLineId { get; set; }

        public int WolhLineNumber { get; set; }

        public Guid? WolhRoleCodeId { get; set; }

        public Guid? WolhLogHistoryTypeId { get; set; }

        public string? WolhFreeText { get; set; }

        public DateTime WolhCreatedDate { get; set; }

        public string? WolhCreatedBy { get; set; }

        public DateTime WolhLastModifiedDate { get; set; }

        public string? WolhLastModifiedBy { get; set; }

        public virtual LogHistoryType? WolhLogHistoryType { get; set; }

        public virtual RoleCode? WolhRoleCode { get; set; }

        public virtual WorkingOrderLine WolhWorkingOrderLine { get; set; } = null!;
    }
}