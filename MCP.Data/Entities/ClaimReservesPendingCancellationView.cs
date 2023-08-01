namespace CED.Data.Entities
{
    public class ClaimReservesPendingCancellationView
    {
        public Guid Id { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public string? CurrentStatusCode { get; set; }

        public Guid AssistancePlanLineId { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public Guid ClientId { get; set; }

        public Guid DossierId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}