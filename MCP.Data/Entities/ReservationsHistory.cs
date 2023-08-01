namespace CED.Data.Entities
{
    public class ReservationsHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? RsvId { get; set; }

        public Guid? RsvInvolvedCoverageId { get; set; }

        public int? RsvSequenceNumber { get; set; }

        public decimal? RsvTransactionValue { get; set; }

        public DateTime? RsvTransactionDate { get; set; }

        public decimal? RsvTotalReservedValue { get; set; }

        public decimal? RsvTotalPaidValue { get; set; }

        public decimal? RsvTotalReceivedValue { get; set; }

        public decimal? RsvCostOfClaims { get; set; }

        public bool? RsvIsManualTransaction { get; set; }

        public string? RsvReservationCause { get; set; }

        public string? RsvClientProductCode { get; set; }

        public DateTime? RsvCreatedDate { get; set; }

        public string? RsvCreatedBy { get; set; }

        public DateTime? RsvLastModifiedDate { get; set; }

        public string? RsvLastModifiedBy { get; set; }
    }
}