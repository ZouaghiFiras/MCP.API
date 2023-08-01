namespace CED.Data.Entities
{
    public class WorkingOrderLinesHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? WolId { get; set; }

        public Guid WolWorkingOrderId { get; set; }

        public Guid? WolDossierWorkActivityId { get; set; }

        public bool WolIsForProductSelection { get; set; }

        public bool? WolIsClosed { get; set; }

        public bool? WolIsManuallyAdded { get; set; }

        public Guid? WolDossierPriorityId { get; set; }

        public Guid? WolParentId { get; set; }

        public DateTime? WolDueDate { get; set; }

        public DateTime? WolCreatedDate { get; set; }

        public string? WolCreatedBy { get; set; }

        public DateTime? WolLastModifiedDate { get; set; }

        public string? WolLastModifiedBy { get; set; }

        public Guid? WolSubContractorId { get; set; }

        public Guid? WolDeliveryAddressId { get; set; }

        public Guid? WolTaskWorkActivityId { get; set; }

        public Guid? WolInvoiceToPayorId { get; set; }

        public Guid? WolDossierPartyId { get; set; }

        public bool? WolIsPayorDossierParty { get; set; }

        public bool? WolIsExecuteVatdeductable { get; set; }

        public bool? WolIsOwnRisk { get; set; }

        public int? WolLineNumber { get; set; }

        public Guid? WolSupplierId { get; set; }

        public Guid? WolPurchaseOrderId { get; set; }

        public Guid? WolPurchaseOrderLineId { get; set; }

        public string? WolYourReference { get; set; }

        public Guid? WolInvoiceToPayorAddressId { get; set; }

        public DateTime? WolDeliveryDate { get; set; }

        public string? WolCurrencyCode { get; set; }

        public bool? WolIsSubContractor { get; set; }

        public string? WolOurReference { get; set; }
    }
}