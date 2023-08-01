namespace CED.Data.Entities
{
    public class DitzoPaymentsJournalFooterView
    {
        public string? Part { get; set; }

        public string? Company { get; set; }

        public int? Linecount { get; set; }

        public decimal? Totaldeb { get; set; }

        public decimal? Totalcred { get; set; }

        public DateTime? Date { get; set; }

        public int? Accountsum { get; set; }

        public int? PaymentYear { get; set; }

        public int? PaymentMonth { get; set; }
    }
}