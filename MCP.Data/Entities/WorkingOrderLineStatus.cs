namespace CED.Data.Entities
{
    public class WorkingOrderLineStatus
    {
        public Guid WlsId { get; set; }

        public byte[] WlsTimeStamp { get; set; } = null!;

        public string WlsCode { get; set; } = null!;

        public string? WlsShortName { get; set; }

        public string WlsLongName { get; set; } = null!;

        public bool WlsInactive { get; set; }

        public string? WlsWorkingOrderLineStatusTypeId { get; set; }

        public Guid? WlsLocalizableEntryId { get; set; }

        public DateTime WlsCreatedDate { get; set; }

        public string? WlsCreatedBy { get; set; }

        public DateTime WlsLastModifiedDate { get; set; }

        public string? WlsLastModifiedBy { get; set; }

        public virtual LocalizableEntry? WlsLocalizableEntry { get; set; }

        public virtual WorkingOrderLineStatusType? WlsWorkingOrderLineStatusType { get; set; }

        public virtual ICollection<WorkingOrderLineStatusHistory> WorkingOrderLineStatusHistories { get; } =
            new List<WorkingOrderLineStatusHistory>();
    }
}