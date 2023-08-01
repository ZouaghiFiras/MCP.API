namespace CED.Data.Entities
{
    public class SalesOrderClientsPendingSingleSalesInvoiceInfo
    {
        public Guid? DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public string? EntrySystem { get; set; }
    }
}