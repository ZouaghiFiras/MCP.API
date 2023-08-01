namespace CED.Data.Entities
{
    public class WorkingOrderLineTrigger
    {
        public Guid WltId { get; set; }

        public byte[] WltTimeStamp { get; set; } = null!;

        public string WltWorkingOrderLineTriggerTypeId { get; set; } = null!;

        public short? WltTriggerSequence { get; set; }

        public DateTime WltCreatedDate { get; set; }

        public string? WltCreatedBy { get; set; }

        public DateTime WltLastModifiedDate { get; set; }

        public string? WltLastModifiedBy { get; set; }

        public virtual WorkingOrderLine Wlt { get; set; } = null!;

        public virtual WorkingOrderLineTriggerType WltWorkingOrderLineTriggerType { get; set; } = null!;
    }
}