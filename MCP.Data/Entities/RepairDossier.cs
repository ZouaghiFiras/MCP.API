namespace CED.Data.Entities
{
    public class RepairDossier
    {
        public Guid RedId { get; set; }

        public byte[] RedTimeStamp { get; set; } = null!;

        public DateTime? RedIncidentDate { get; set; }

        public string? RedIncidentStreet { get; set; }

        public string? RedIncidentCity { get; set; }

        public bool? RedHasExpertIntake { get; set; }

        public bool? RedIsExpertiseDossier { get; set; }

        public decimal? RedDamageAmountEstimate { get; set; }

        public decimal? RedDamageAmountFinal { get; set; }

        public string? RedReportingParty { get; set; }

        public DateTime RedCreatedDate { get; set; }

        public string? RedCreatedBy { get; set; }

        public DateTime RedLastModifiedDate { get; set; }

        public string? RedLastModifiedBy { get; set; }

        public virtual Dossier Red { get; set; } = null!;
    }
}