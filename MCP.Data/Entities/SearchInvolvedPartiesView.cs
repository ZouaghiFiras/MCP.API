namespace CED.Data.Entities
{
    public class SearchInvolvedPartiesView
    {
        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public Guid ProductId { get; set; }

        public string? ProductCode { get; set; }

        public string? ProductName { get; set; }

        public Guid? DossierStatusId { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public string? DossierStatusTypeId { get; set; }

        public string? DossierStatusTypeName { get; set; }

        public string InvolvedPartyFullName { get; set; } = null!;

        public string? InvolvedPartyPostalCode { get; set; }

        public string? InvolvedPartyHouseNumber { get; set; }

        public string? InvolvedPartyHouseNumberAddition { get; set; }

        public DateTime? InvolvedPartyDateOfBirth { get; set; }

        public string? EntrySystem { get; set; }
    }
}