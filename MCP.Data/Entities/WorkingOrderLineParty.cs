namespace CED.Data.Entities
{
    public class WorkingOrderLineParty
    {
        public Guid WolpId { get; set; }

        public byte[] WolpTimeStamp { get; set; } = null!;

        public Guid WolpWorkingOrderPartyId { get; set; }

        public Guid WolpWorkingOrderLineId { get; set; }

        public DateTime WolpCreatedDate { get; set; }

        public string? WolpCreatedBy { get; set; }

        public DateTime WolpLastModifiedDate { get; set; }

        public string? WolpLastModifiedBy { get; set; }

        public virtual WorkingOrderLine WolpWorkingOrderLine { get; set; } = null!;

        public virtual WorkingOrderParty WolpWorkingOrderParty { get; set; } = null!;

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();
    }
}