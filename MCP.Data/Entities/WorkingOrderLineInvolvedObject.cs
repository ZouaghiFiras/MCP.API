namespace CED.Data.Entities
{
    public class WorkingOrderLineInvolvedObject
    {
        public Guid WolioId { get; set; }

        public Guid WolioWorkingOrderLineId { get; set; }

        public Guid WolioWorkingOrderInvolvedObjectId { get; set; }

        public DateTime WolioCreatedDate { get; set; }

        public string? WolioCreatedBy { get; set; }

        public DateTime WolioLastModifiedDate { get; set; }

        public string? WolioLastModifiedBy { get; set; }

        public virtual WorkingOrderInvolvedObject WolioWorkingOrderInvolvedObject { get; set; } = null!;

        public virtual WorkingOrderLine WolioWorkingOrderLine { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();
    }
}