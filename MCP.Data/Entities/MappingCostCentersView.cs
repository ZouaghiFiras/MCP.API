namespace CED.Data.Entities
{
    public class MappingCostCentersView
    {
        public string OldCostCenterCode { get; set; } = null!;

        public string NewCostCenterCode { get; set; } = null!;

        public Guid OldCostCenterId { get; set; }

        public Guid NewCostCenterId { get; set; }
    }
}