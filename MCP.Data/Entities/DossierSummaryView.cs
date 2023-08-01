namespace CED.Data.Entities
{
    public class DossierSummaryView
    {
        public Guid Id { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? DossierNumber { get; set; }

        public string? EntrySystem { get; set; }

        public Guid ClientId { get; set; }

        public Guid? AssignmentId { get; set; }

        public string? AssignmentNumber { get; set; }

        public Guid? DossierPartyId { get; set; }

        public string? DossierPartyRoleCode { get; set; }

        public Guid? InvolvedPartyId { get; set; }

        public string? PartyNumber { get; set; }

        public string? PartyFullName { get; set; }

        public DateTime? PartyDateOfBirth { get; set; }

        public Guid? DepartmentId { get; set; }

        public string? DepartmentCode { get; set; }

        public string DepartmentName { get; set; } = null!;

        public Guid? BusinessUnitId { get; set; }

        public string? BusinessUnitCode { get; set; }

        public string BusinessUnitName { get; set; } = null!;

        public Guid? LegalEntityId { get; set; }

        public string? LegalEntityCode { get; set; }

        public string LegalEntityName { get; set; } = null!;

        public Guid? CostUnitId { get; set; }

        public string? CostUnitCode { get; set; }

        public string? CostUnitName { get; set; }

        public Guid? CostCenterId { get; set; }

        public string? CostCenterCode { get; set; }

        public string? CostCenterName { get; set; }

        public string? LiabilityStatusCode { get; set; }

        public string? LiabilityStatusName { get; set; }

        public bool? IsLiabilityConfirmed { get; set; }

        public bool? NoFraud { get; set; }

        public Guid? GeneralSupplierId { get; set; }

        public bool IsDossierPartyInsuree { get; set; }

        public bool IsDossierPartyPatient { get; set; }

        public string? DossierStatusCode { get; set; }

        public string? DossierStatusName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}