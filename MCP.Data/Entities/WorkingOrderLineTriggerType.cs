namespace CED.Data.Entities
{
    public class WorkingOrderLineTriggerType
    {
        public string WolttId { get; set; } = null!;

        public byte[] WolttTimeStamp { get; set; } = null!;

        public string WolttName { get; set; } = null!;

        public bool WolttInactive { get; set; }

        public DateTime WolttCreatedDate { get; set; }

        public string? WolttCreatedBy { get; set; }

        public DateTime WolttLastModifiedDate { get; set; }

        public string? WolttLastModifiedBy { get; set; }

        public virtual ICollection<WorkingOrderLineTrigger> WorkingOrderLineTriggers { get; } =
            new List<WorkingOrderLineTrigger>();
    }
}