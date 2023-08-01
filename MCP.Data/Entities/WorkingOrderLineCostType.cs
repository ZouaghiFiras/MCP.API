namespace CED.Data.Entities
{
    public class WorkingOrderLineCostType
    {
        public Guid WocId { get; set; }

        public byte[] WocTimeStamp { get; set; } = null!;

        public string WocCode { get; set; } = null!;

        public string? WocShortName { get; set; }

        public string WocLongName { get; set; } = null!;

        public bool WocInactive { get; set; }

        public Guid? WocLocalizableEntryId { get; set; }

        public DateTime WocCreatedDate { get; set; }

        public string? WocCreatedBy { get; set; }

        public DateTime WocLastModifiedDate { get; set; }

        public string? WocLastModifiedBy { get; set; }

        public virtual LocalizableEntry? WocLocalizableEntry { get; set; }

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();
    }
}