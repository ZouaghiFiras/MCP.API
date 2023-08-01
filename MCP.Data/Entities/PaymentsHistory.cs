namespace CED.Data.Entities
{
    public class PaymentsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? PayId { get; set; }

        public Guid? PayDossierPartyId { get; set; }

        public Guid? PayInvolvedCoverageId { get; set; }

        public int? PaySequenceNumber { get; set; }

        public string? PayCurrencyCode { get; set; }

        public string? PayIban { get; set; }

        public decimal? PayPaymentValue { get; set; }

        public DateTime? PayPaymentDate { get; set; }

        public string? PayReference { get; set; }

        public string? PayPaymentMethod { get; set; }

        public string? PayPaymentStatus { get; set; }

        public string? PayPaymentSource { get; set; }

        public string? PayPaymentType { get; set; }

        public decimal? PayDivergentRecoveryValue { get; set; }

        public bool? PayIsSentToClearingHouse { get; set; }

        public bool? PayIsTotalLoss { get; set; }

        public Guid? PayEmployeeId { get; set; }

        public DateTime? PayCreatedDate { get; set; }

        public string? PayCreatedBy { get; set; }

        public DateTime? PayLastModifiedDate { get; set; }

        public string? PayLastModifiedBy { get; set; }

        public DateTime? PayCurrentStatusHistoryStartDate { get; set; }

        public Guid? PayCurrentStatusHistoryId { get; set; }

        public string? PayCurrentStatusCode { get; set; }
    }
}