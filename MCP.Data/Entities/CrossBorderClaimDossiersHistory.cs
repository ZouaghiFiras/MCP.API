namespace CED.Data.Entities
{
    public class CrossBorderClaimDossiersHistory
    {
        public Guid HistoryId { get; set; }

        public string? HistoryTriggeredBy { get; set; }

        public string? HistoryTriggerType { get; set; }

        public DateTime? HistoryTriggerDateTime { get; set; }

        public Guid? CbcId { get; set; }

        public DateTime? CbcIncidentDate { get; set; }

        public string? CbcIncidentCountryCode { get; set; }

        public string? CbcClientIncidentNumber { get; set; }

        public string? CbcClientInvoiceEmail { get; set; }

        public string? CbcGreenCardNumber { get; set; }

        public bool? CbcIsDomesticClaim { get; set; }

        public DateTime? CbcCreatedDate { get; set; }

        public string? CbcCreatedBy { get; set; }

        public DateTime? CbcLastModifiedDate { get; set; }

        public string? CbcLastModifiedBy { get; set; }
    }
}