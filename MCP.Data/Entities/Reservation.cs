namespace CED.Data.Entities
{
    public class Reservation
    {
        public Guid RsvId { get; set; }

        public byte[] RsvTimeStamp { get; set; } = null!;

        public Guid RsvInvolvedCoverageId { get; set; }

        public int RsvSequenceNumber { get; set; }

        public decimal RsvTransactionValue { get; set; }

        public DateTime RsvTransactionDate { get; set; }

        public decimal RsvTotalReservedValue { get; set; }

        public decimal RsvTotalPaidValue { get; set; }

        public decimal RsvTotalReceivedValue { get; set; }

        public decimal RsvCostOfClaims { get; set; }

        public bool RsvIsManualTransaction { get; set; }

        public string? RsvReservationCause { get; set; }

        public string? RsvClientProductCode { get; set; }

        public DateTime RsvCreatedDate { get; set; }

        public string? RsvCreatedBy { get; set; }

        public DateTime RsvLastModifiedDate { get; set; }

        public string? RsvLastModifiedBy { get; set; }

        public virtual InvolvedCoverage RsvInvolvedCoverage { get; set; } = null!;
    }
}