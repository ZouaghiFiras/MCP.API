namespace CED.Data.Entities
{
    public class SalesPayment
    {
        public Guid SipId { get; set; }

        public byte[] SipTimeStamp { get; set; } = null!;

        public Guid SipSalesInvoiceId { get; set; }

        public Guid SipBankStatementLineId { get; set; }

        public decimal SipPaymentValue { get; set; }

        public DateTime SipCreatedDate { get; set; }

        public string? SipCreatedBy { get; set; }

        public DateTime SipLastModifiedDate { get; set; }

        public string? SipLastModifiedBy { get; set; }

        public Guid? SipCurrentStatusHistoryId { get; set; }

        public DateTime? SipCurrentStatusHistoryStartDate { get; set; }

        public string? SipCurrentStatusCode { get; set; }

        public virtual ICollection<SalesPaymentStatusHistory> SalesPaymentStatusHistories { get; } =
            new List<SalesPaymentStatusHistory>();

        public virtual BankStatementLine SipBankStatementLine { get; set; } = null!;

        public virtual SalesInvoice SipSalesInvoice { get; set; } = null!;
    }
}