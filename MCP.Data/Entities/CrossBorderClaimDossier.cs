namespace CED.Data.Entities
{
    public class CrossBorderClaimDossier
    {
        public Guid CbcId { get; set; }

        public byte[] CbcTimeStamp { get; set; } = null!;

        public DateTime CbcIncidentDate { get; set; }

        public string CbcIncidentCountryCode { get; set; } = null!;

        public string? CbcClientIncidentNumber { get; set; }

        public string? CbcClientInvoiceEmail { get; set; }

        public string? CbcGreenCardNumber { get; set; }

        public bool CbcIsDomesticClaim { get; set; }

        public DateTime CbcCreatedDate { get; set; }

        public string? CbcCreatedBy { get; set; }

        public DateTime CbcLastModifiedDate { get; set; }

        public string? CbcLastModifiedBy { get; set; }

        public virtual Dossier Cbc { get; set; } = null!;
    }
}