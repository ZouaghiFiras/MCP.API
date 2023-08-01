namespace CED.Data.Entities
{
    public class ClaimReservesOnWorkingOrderSelectView
    {
        public Guid Id { get; set; }

        public string? ClaimReserveNumber { get; set; }

        public decimal? OpenAmount { get; set; }

        public Guid LegalEntityId { get; set; }

        public Guid DepartmentId { get; set; }

        public Guid ClaimReserveTypeId { get; set; }

        public string ClaimReserveTypeName { get; set; } = null!;

        public Guid? WorkingOrderId { get; set; }

        public Guid? WorkingOrderLineId { get; set; }

        public Guid? WorkingOrderLineCostId { get; set; }

        public string ClaimReserveClassificationId { get; set; } = null!;

        public string ClaimReserveClassificationName { get; set; } = null!;

        public Guid ServiceId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public Guid DossierId { get; set; }

        public Guid? DossierAssignmentId { get; set; }

        public string? DossierPartyName { get; set; }

        public Guid? InsureeId { get; set; }

        public string? InsureeCountryCodeIso3 { get; set; }

        public string? InsureeFormattedName { get; set; }

        public string? InsureePolicyNumber { get; set; }

        public Guid ClientId { get; set; }

        public string ClientName { get; set; } = null!;

        public string? ClientProductCode { get; set; }

        public string? EntrySystem { get; set; }

        public string? CurrentStatusName { get; set; }

        public Guid? InsurerId { get; set; }

        public string InsurerName { get; set; } = null!;

        public Guid? MandateId { get; set; }

        public string MandateName { get; set; } = null!;

        public string? InvolvedPartyFullName { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}