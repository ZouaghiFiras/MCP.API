namespace CED.Data.Entities
{
    public class WorkingOrderLineAttachment
    {
        public Guid WolaId { get; set; }

        public byte[] WolaTimeStamp { get; set; } = null!;

        public Guid WolaWorkingOrderLineId { get; set; }

        public Guid WolaDocumentId { get; set; }

        public DateTime WolaCreatedDate { get; set; }

        public string? WolaCreatedBy { get; set; }

        public DateTime WolaLastModifiedDate { get; set; }

        public string? WolaLastModifiedBy { get; set; }

        public virtual Document WolaDocument { get; set; } = null!;

        public virtual WorkingOrderLine WolaWorkingOrderLine { get; set; } = null!;
    }
}