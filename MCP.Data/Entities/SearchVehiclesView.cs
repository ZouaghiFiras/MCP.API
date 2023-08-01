namespace CED.Data.Entities
{
    public class SearchVehiclesView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DossierStatusId { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? DossierStatusTypeId { get; set; }

        public string? DossierStatusTypeName { get; set; }

        public string? LicensePlate { get; set; }

        public Guid InvolvedCoverageId { get; set; }

        public string InsurancePolicyNumber { get; set; } = null!;

        public string? EntrySystem { get; set; }
    }
}