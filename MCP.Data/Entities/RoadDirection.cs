namespace CED.Data.Entities
{
    public class RoadDirection
    {
        public string RddId { get; set; } = null!;

        public byte[] RddTimeStamp { get; set; } = null!;

        public string RddName { get; set; } = null!;

        public bool RddInactive { get; set; }

        public Guid? RddLocalizableEntryId { get; set; }

        public DateTime RddCreatedDate { get; set; }

        public string? RddCreatedBy { get; set; }

        public DateTime RddLastModifiedDate { get; set; }

        public string? RddLastModifiedBy { get; set; }

        public virtual LocalizableEntry? RddLocalizableEntry { get; set; }

        public virtual ICollection<RoadLocation1> RoadLocation1s { get; } = new List<RoadLocation1>();
    }
}