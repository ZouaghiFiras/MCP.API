namespace CED.Data.Entities
{
    public class DossierPartyInvolvedCoverage
    {
        public Guid DpicId { get; set; }

        public Guid DpicDossierPartyId { get; set; }

        public Guid DpicInvolvedCoverageId { get; set; }

        public DateTime DpicCreatedDate { get; set; }

        public string? DpicCreatedBy { get; set; }

        public DateTime DpicLastModifiedDate { get; set; }

        public string? DpicLastModifiedBy { get; set; }

        public virtual DossierParty DpicDossierParty { get; set; } = null!;

        public virtual InvolvedCoverage DpicInvolvedCoverage { get; set; } = null!;
    }
}