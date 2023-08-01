namespace CED.Data.Entities
{
    public class AssistancePlansHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? AspId { get; set; }

        public string? AspAssistancePlanNumber { get; set; }

        public Guid? AspAssistancePlanTypeId { get; set; }

        public Guid? AspDossierId { get; set; }

        public DateTime? AspStartDate { get; set; }

        public string? AspLeadCurrencyCode { get; set; }

        public string? AspForeignCurrencyCode { get; set; }

        public Guid? AspSupplierId { get; set; }

        public string? AspSupplierComments { get; set; }

        public Guid? AspPickupLocationId { get; set; }

        public string? AspPickupComments { get; set; }

        public Guid? AspDropoffLocationId { get; set; }

        public string? AspDropoffComments { get; set; }

        public bool? AspExpectRepairOnSpot { get; set; }

        public bool? AspRequireDirectTransport { get; set; }

        public string? AspDistanceComments { get; set; }

        public string? AspGeneralComments { get; set; }

        public bool? AspInvoiceRecipientIsLegalEntity { get; set; }

        public Guid? AspInvolvedObjectId { get; set; }

        public Guid? AspAssistanceExecutorOrganizationUnitId { get; set; }

        public DateTime? AspActivationDate { get; set; }

        public DateTime? AspExecutionStartDate { get; set; }

        public DateTime? AspExecutionArrivalDate { get; set; }

        public DateTime? AspExecutionEndDate { get; set; }

        public DateTime? AspCreatedDate { get; set; }

        public string? AspCreatedBy { get; set; }

        public DateTime? AspLastModifiedDate { get; set; }

        public string? AspLastModifiedBy { get; set; }

        public bool? AspLateCancellation { get; set; }

        public DateTime? AspCurrentStatusHistoryStartDate { get; set; }

        public string? AspAddtionalComment1 { get; set; }

        public string? AspAddtionalComment2 { get; set; }

        public Guid? AspCurrentStatusHistoryId { get; set; }

        public Guid? AspDossierPartyId { get; set; }

        public string? AspAddtionalComment4 { get; set; }

        public string? AspAddtionalComment3 { get; set; }

        public Guid? AspInvoiceRecipientId { get; set; }

        public string? AspCurrentStatusCode { get; set; }
    }
}