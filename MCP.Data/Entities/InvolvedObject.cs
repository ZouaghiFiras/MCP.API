namespace CED.Data.Entities
{
    public class InvolvedObject
    {
        public Guid IobId { get; set; }

        public byte[] IobTimeStamp { get; set; } = null!;

        public Guid IobDossierId { get; set; }

        public Guid IobInsuranceObjectId { get; set; }

        public Guid? IobInvolvedCoverageId { get; set; }

        public int IobSequenceNumber { get; set; }

        public bool IobIsActive { get; set; }

        public DateTime IobCreatedDate { get; set; }

        public string? IobCreatedBy { get; set; }

        public DateTime IobLastModifiedDate { get; set; }

        public string? IobLastModifiedBy { get; set; }

        public virtual ICollection<AssistancePlan> AssistancePlans { get; } = new List<AssistancePlan>();

        public virtual ICollection<DossierAssignmentInvolvedObject> DossierAssignmentInvolvedObjects { get; } =
            new List<DossierAssignmentInvolvedObject>();

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual ICollection<DossierPartyObjectRelation> DossierPartyObjectRelations { get; } =
            new List<DossierPartyObjectRelation>();

        public virtual ICollection<DossierWorkActivity> DossierWorkActivities { get; } =
            new List<DossierWorkActivity>();

        public virtual ICollection<InvolvedComponent> InvolvedComponents { get; } = new List<InvolvedComponent>();

        public virtual ICollection<InvolvedCoverageObjectRelation> InvolvedCoverageObjectRelations { get; } =
            new List<InvolvedCoverageObjectRelation>();

        public virtual ICollection<InvolvedObjectDamageLocation> InvolvedObjectDamageLocations { get; } =
            new List<InvolvedObjectDamageLocation>();

        public virtual Dossier IobDossier { get; set; } = null!;

        public virtual InsuranceObject IobInsuranceObject { get; set; } = null!;

        public virtual InvolvedCoverage? IobInvolvedCoverage { get; set; }

        public virtual Person? Person { get; set; }

        public virtual Property? Property { get; set; }

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<Regre> Regres { get; } = new List<Regre>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual Vehicle? Vehicle { get; set; }

        public virtual ICollection<WorkingOrderInvolvedObject> WorkingOrderInvolvedObjects { get; } =
            new List<WorkingOrderInvolvedObject>();

        public virtual ICollection<WorkingOrderLineCost> WorkingOrderLineCosts { get; } =
            new List<WorkingOrderLineCost>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();
    }
}