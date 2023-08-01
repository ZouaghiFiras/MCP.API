namespace CED.Data.Entities
{
    public class WorkingOrderVisitInformation
    {
        public Guid WovId { get; set; }

        public byte[] WovTimeStamp { get; set; } = null!;

        public Guid WovWorkingOrderId { get; set; }

        public Guid WovVisitInformationId { get; set; }

        public DateTime WovCreatedDate { get; set; }

        public string? WovCreatedBy { get; set; }

        public DateTime WovLastModifiedDate { get; set; }

        public string? WovLastModifiedBy { get; set; }

        public virtual VisitInformation WovVisitInformation { get; set; } = null!;

        public virtual WorkingOrder WovWorkingOrder { get; set; } = null!;
    }
}