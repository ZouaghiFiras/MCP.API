namespace CED.Data.Entities
{
    public class WorkingOrderStatus
    {
        public Guid WstId { get; set; }

        public byte[] WstTimeStamp { get; set; } = null!;

        public string WstCode { get; set; } = null!;

        public string? WstShortName { get; set; }

        public string WstLongName { get; set; } = null!;

        public bool WstInactive { get; set; }

        public string? WstWorkingOrderStatusTypeId { get; set; }

        public Guid? WstLocalizableEntryId { get; set; }

        public DateTime WstCreatedDate { get; set; }

        public string? WstCreatedBy { get; set; }

        public DateTime WstLastModifiedDate { get; set; }

        public string? WstLastModifiedBy { get; set; }

        public virtual ICollection<WorkingOrderStatusHistory> WorkingOrderStatusHistories { get; } =
            new List<WorkingOrderStatusHistory>();

        public virtual LocalizableEntry? WstLocalizableEntry { get; set; }

        public virtual WorkingOrderStatusType? WstWorkingOrderStatusType { get; set; }
    }
}