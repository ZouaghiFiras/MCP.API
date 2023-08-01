namespace CED.Data.Entities
{
    public class RoadSection
    {
        public string RdsId { get; set; } = null!;

        public bool RdsIsMainRoadSection { get; set; }

        public bool RdsInactive { get; set; }

        public Guid? RdsLocalizableEntryId { get; set; }

        public DateTime RdsCreatedDate { get; set; }

        public string? RdsCreatedBy { get; set; }

        public DateTime RdsLastModifiedDate { get; set; }

        public string? RdsLastModifiedBy { get; set; }
    }
}