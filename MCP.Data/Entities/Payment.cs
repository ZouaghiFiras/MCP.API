namespace CED.Data.Entities
{
    public class Payment
    {
        public Guid PayId { get; set; }

        public byte[] PayTimeStamp { get; set; } = null!;

        public Guid PayDossierPartyId { get; set; }

        public Guid PayInvolvedCoverageId { get; set; }

        public int PaySequenceNumber { get; set; }

        public string PayCurrencyCode { get; set; } = null!;

        public string PayIban { get; set; } = null!;

        public decimal PayPaymentValue { get; set; }

        public DateTime? PayPaymentDate { get; set; }

        public string? PayReference { get; set; }

        public string PayPaymentMethod { get; set; } = null!;

        public string? PayPaymentStatus { get; set; }

        public string? PayPaymentSource { get; set; }

        public string? PayPaymentType { get; set; }

        public decimal PayDivergentRecoveryValue { get; set; }

        public bool PayIsSentToClearingHouse { get; set; }

        public bool PayIsTotalLoss { get; set; }

        public Guid? PayEmployeeId { get; set; }

        public Guid? PayCurrentStatusHistoryId { get; set; }

        public DateTime? PayCurrentStatusHistoryStartDate { get; set; }

        public string? PayCurrentStatusCode { get; set; }

        public DateTime PayCreatedDate { get; set; }

        public string? PayCreatedBy { get; set; }

        public DateTime PayLastModifiedDate { get; set; }

        public string? PayLastModifiedBy { get; set; }

        public virtual ICollection<Claim> Claims { get; } = new List<Claim>();

        public virtual DossierParty PayDossierParty { get; set; } = null!;

        public virtual Employee? PayEmployee { get; set; }

        public virtual InvolvedCoverage PayInvolvedCoverage { get; set; } = null!;

        public virtual ICollection<PaymentStatusHistory> PaymentStatusHistories { get; } =
            new List<PaymentStatusHistory>();
    }
}