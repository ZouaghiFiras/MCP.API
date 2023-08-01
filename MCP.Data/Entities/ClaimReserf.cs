namespace CED.Data.Entities
{
    public class ClaimReserf
    {
        public Guid CrvId { get; set; }

        public byte[] CrvTimeStamp { get; set; } = null!;

        public string? CrvClaimReserveNumber { get; set; }

        public DateTime CrvClaimReserveDate { get; set; }

        public string CrvCurrencyCode { get; set; } = null!;

        public decimal CrvTotalReservedValue { get; set; }

        public decimal CrvTotalClaimValue { get; set; }

        public Guid CrvLegalEntityId { get; set; }

        public Guid CrvDepartmentId { get; set; }

        public Guid CrvClaimReserveTypeId { get; set; }

        public string CrvClaimReserveClassificationId { get; set; } = null!;

        public Guid CrvInvolvedCoverageId { get; set; }

        public Guid CrvDossierId { get; set; }

        public Guid? CrvDossierAssignmentId { get; set; }

        public Guid? CrvDossierPartyId { get; set; }

        public string? CrvClientProductCode { get; set; }

        public Guid CrvClientId { get; set; }

        public string CrvClientCurrencyCode { get; set; } = null!;

        public decimal CrvTotalClientReservedValue { get; set; }

        public decimal CrvTotalClientClaimValue { get; set; }

        public string CrvLeadCurrencyCode { get; set; } = null!;

        public decimal CrvTotalLeadReservedValue { get; set; }

        public decimal CrvTotalLeadClaimValue { get; set; }

        public string? CrvEntrySystem { get; set; }

        public string? CrvEntryNumber { get; set; }

        public string? CrvEntryBatch { get; set; }

        public Guid? CrvCurrentStatusHistoryId { get; set; }

        public DateTime? CrvCurrentStatusHistoryStartDate { get; set; }

        public string? CrvCurrentStatusCode { get; set; }

        public DateTime CrvCreatedDate { get; set; }

        public string? CrvCreatedBy { get; set; }

        public DateTime CrvLastModifiedDate { get; set; }

        public string? CrvLastModifiedBy { get; set; }

        public virtual ICollection<ClaimReserveAssistancePlan> ClaimReserveAssistancePlans { get; } =
            new List<ClaimReserveAssistancePlan>();

        public virtual ICollection<ClaimReserveLine> ClaimReserveLines { get; } = new List<ClaimReserveLine>();

        public virtual ICollection<ClaimReservePayment> ClaimReservePayments { get; } = new List<ClaimReservePayment>();

        public virtual ICollection<ClaimReserveStatusHistory> ClaimReserveStatusHistories { get; } =
            new List<ClaimReserveStatusHistory>();

        public virtual ICollection<ClaimReserveWorkingOrder> ClaimReserveWorkingOrders { get; } =
            new List<ClaimReserveWorkingOrder>();

        public virtual ClaimReserveClassification CrvClaimReserveClassification { get; set; } = null!;

        public virtual ClaimReserveType CrvClaimReserveType { get; set; } = null!;

        public virtual Client CrvClient { get; set; } = null!;

        public virtual Department CrvDepartment { get; set; } = null!;

        public virtual Dossier CrvDossier { get; set; } = null!;

        public virtual DossierAssignment? CrvDossierAssignment { get; set; }

        public virtual DossierParty? CrvDossierParty { get; set; }

        public virtual InvolvedCoverage CrvInvolvedCoverage { get; set; } = null!;

        public virtual LegalEntity CrvLegalEntity { get; set; } = null!;
    }
}