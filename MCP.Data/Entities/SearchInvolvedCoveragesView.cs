namespace CED.Data.Entities
{
    public class SearchInvolvedCoveragesView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public Guid InsuranceCoverageId { get; set; }

        public string? InsuranceCoverageCode { get; set; }

        public string? InsuranceCoverageName { get; set; }

        public bool? CoveraceConfirmed { get; set; }

        public DateTime? ConfirmationDate { get; set; }

        public string? ClientOrderNumber { get; set; }

        public string? ClientCaseNumber { get; set; }

        public string? EntrySystem { get; set; }
    }
}