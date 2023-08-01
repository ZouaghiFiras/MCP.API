namespace CED.Data.Entities
{
    public class CompletedDossierPendingSalesOrder
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public string AssistancePlanStatus { get; set; } = null!;

        public Guid CompletedByEmployeeId { get; set; }

        public Guid ClientId { get; set; }

        public string? FeeSettlementName { get; set; }

        public string? InvoiceRuleTypeId { get; set; }
    }
}