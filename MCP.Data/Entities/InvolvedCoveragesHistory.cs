namespace CED.Data.Entities
{
    public class InvolvedCoveragesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? IcoId { get; set; }

        public Guid? IcoDossierId { get; set; }

        public Guid? IcoInsuranceCoverageId { get; set; }

        public Guid? IcoInsurancePolicyId { get; set; }

        public string? IcoInsurancePolicyNumber { get; set; }

        public decimal? IcoCoverageAmount { get; set; }

        public string? IcoCurrencyCode { get; set; }

        public decimal? IcoCoveragePercentage { get; set; }

        public bool? IcoCoverageConfirmed { get; set; }

        public DateTime? IcoConfirmationDate { get; set; }

        public bool? IcoInactive { get; set; }

        public DateTime? IcoCreatedDate { get; set; }

        public string? IcoCreatedBy { get; set; }

        public DateTime? IcoLastModifiedDate { get; set; }

        public string? IcoLastModifiedBy { get; set; }

        public Guid? IcoCoverageProductId { get; set; }

        public short? IcoPriority { get; set; }

        public decimal? IcoOwnRiskAmount { get; set; }
    }
}