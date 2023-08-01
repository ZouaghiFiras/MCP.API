namespace CED.Data.Entities
{
    public class DossierWorkActivitiesWithoutFeeSalesOrdersView
    {
        public Guid Id { get; set; }

        public Guid DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public Guid? DossierPartyId { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public Guid WorkActivitityId { get; set; }

        public Guid? ActivitityOptionId { get; set; }

        public Guid? ActivitityExecutionId { get; set; }

        public string? WorkActivityName { get; set; }

        public string? ActivityOptionName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}