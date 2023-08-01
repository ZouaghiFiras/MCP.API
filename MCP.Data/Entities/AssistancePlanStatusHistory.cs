namespace CED.Data.Entities
{
    public class AssistancePlanStatusHistory
    {
        public Guid AphId { get; set; }

        public byte[] AphTimeStamp { get; set; } = null!;

        public Guid AphAssistancePlanId { get; set; }

        public Guid AphAssistancePlanStatusId { get; set; }

        public Guid AphEmployeeId { get; set; }

        public DateTime AphStartDate { get; set; }

        public string? AphStatusChangeReason { get; set; }

        public DateTime AphCreatedDate { get; set; }

        public string? AphCreatedBy { get; set; }

        public DateTime AphLastModifiedDate { get; set; }

        public string? AphLastModifiedBy { get; set; }

        public virtual AssistancePlan AphAssistancePlan { get; set; } = null!;

        public virtual AssistancePlanStatus AphAssistancePlanStatus { get; set; } = null!;

        public virtual Employee AphEmployee { get; set; } = null!;
    }
}