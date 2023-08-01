namespace CED.Data.Entities
{
    public class InvolvedCoverage
    {
        public Guid IcoId { get; set; }

        public byte[] IcoTimeStamp { get; set; } = null!;

        public Guid IcoDossierId { get; set; }

        public Guid IcoInsuranceCoverageId { get; set; }

        public Guid? IcoCoverageProductId { get; set; }

        public Guid? IcoInsurancePolicyId { get; set; }

        public string? IcoInsurancePolicyNumber { get; set; }

        public decimal? IcoCoverageAmount { get; set; }

        public string? IcoCurrencyCode { get; set; }

        public decimal? IcoCoveragePercentage { get; set; }

        public bool? IcoCoverageConfirmed { get; set; }

        public DateTime? IcoConfirmationDate { get; set; }

        public bool? IcoInactive { get; set; }

        public short? IcoPriority { get; set; }

        public DateTime IcoCreatedDate { get; set; }

        public string? IcoCreatedBy { get; set; }

        public DateTime IcoLastModifiedDate { get; set; }

        public string? IcoLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlanCoverage> AssistancePlanCoverages { get; } =
            new List<AssistancePlanCoverage>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual ICollection<DossierPartyInvolvedCoverage> DossierPartyInvolvedCoverages { get; } =
            new List<DossierPartyInvolvedCoverage>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual CoverageProduct? IcoCoverageProduct { get; set; }

        public virtual Dossier IcoDossier { get; set; } = null!;

        public virtual InsuranceCoverage IcoInsuranceCoverage { get; set; } = null!;

        public virtual InsurancePolicy? IcoInsurancePolicy { get; set; }

        public virtual ICollection<InvolvedCoverageObjectRelation> InvolvedCoverageObjectRelations { get; } =
            new List<InvolvedCoverageObjectRelation>();

        public virtual ICollection<InvolvedObject> InvolvedObjects { get; } = new List<InvolvedObject>();

        public virtual ICollection<Payment> Payments { get; } = new List<Payment>();

        public virtual ICollection<Regre> Regres { get; } = new List<Regre>();

        public virtual ICollection<Reservation> Reservations { get; } = new List<Reservation>();

        public virtual ICollection<SalesOrderCorrectionLine> SalesOrderCorrectionLines { get; } =
            new List<SalesOrderCorrectionLine>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();

        public static implicit operator InvolvedCoverage(InsurancePolicy v)
        {
            throw new NotImplementedException();
        }
    }
}