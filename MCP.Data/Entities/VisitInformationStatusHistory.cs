namespace CED.Data.Entities
{
    public class VisitInformationStatusHistory
    {
        public Guid VishId { get; set; }

        public byte[] VishTimeStamp { get; set; } = null!;

        public Guid VishVisitInformationId { get; set; }

        public Guid VishVisitInformationStatusId { get; set; }

        public Guid VishEmployeeId { get; set; }

        public DateTime VishStartDate { get; set; }

        public string? VishStatusChangeReason { get; set; }

        public DateTime VishCreatedDate { get; set; }

        public string? VishCreatedBy { get; set; }

        public DateTime VishLastModifiedDate { get; set; }

        public string? VishLastModifiedBy { get; set; }

        public Guid? VishReasonId { get; set; }

        public virtual VisitInformation VishVisitInformation { get; set; } = null!;

        public virtual VisitInformationStatus VishVisitInformationStatus { get; set; } = null!;
    }
}