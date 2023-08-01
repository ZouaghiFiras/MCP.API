namespace CED.Data.Entities
{
    public class DossierCostType
    {
        public Guid DctId { get; set; }

        public byte[] DctTimeStamp { get; set; } = null!;

        public string DctName { get; set; } = null!;

        public bool DctInactive { get; set; }

        public Guid? DctLocalizableEntryId { get; set; }

        public DateTime DctCreatedDate { get; set; }

        public string? DctCreatedBy { get; set; }

        public DateTime DctLastModifiedDate { get; set; }

        public string? DctLastModifiedBy { get; set; }

        public virtual LocalizableEntry? DctLocalizableEntry { get; set; }

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();
    }
}