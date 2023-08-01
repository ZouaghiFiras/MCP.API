namespace CED.Data.Entities
{
    public class SalesOrdersReadyForInvoicingView
    {
        public Guid Id { get; set; }

        public bool IsFee { get; set; }

        public Guid ClientId { get; set; }

        public Guid? DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? CurrentStatusCode { get; set; }
    }
}