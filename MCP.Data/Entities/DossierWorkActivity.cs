namespace CED.Data.Entities
{
    public class DossierWorkActivity
    {
        public Guid DwaId { get; set; }

        public byte[] DwaTimeStamp { get; set; } = null!;

        public Guid DwaDossierId { get; set; }

        public Guid? DwaDossierAssignmentId { get; set; }

        public Guid DwaWorkActivityId { get; set; }

        public Guid? DwaDossierPartyId { get; set; }

        public Guid? DwaInvolvedObjectId { get; set; }

        public Guid? DwaInvolvedCoverageId { get; set; }

        public Guid? DwaActivityExecutionId { get; set; }

        public Guid? DwaActivityOptionId { get; set; }

        public bool DwaInactive { get; set; }

        public DateTime DwaCreatedDate { get; set; }

        public string? DwaCreatedBy { get; set; }

        public DateTime DwaLastModifiedDate { get; set; }

        public string? DwaLastModifiedBy { get; set; }

        public Guid? DwaProductId { get; set; }

        public Guid? DwaReportingFormId { get; set; }

        public bool? DwaIsInvoiceable { get; set; }

        public bool DwaIsActivityOptionManuallySelected { get; set; }

        public virtual DossierWorkActivityTrigger? DossierWorkActivityTrigger { get; set; }

        public virtual ActivityExecution? DwaActivityExecution { get; set; }

        public virtual ActivityOption? DwaActivityOption { get; set; }

        public virtual Dossier DwaDossier { get; set; } = null!;

        public virtual DossierAssignment? DwaDossierAssignment { get; set; }

        public virtual DossierParty? DwaDossierParty { get; set; }

        public virtual InvolvedCoverage? DwaInvolvedCoverage { get; set; }

        public virtual InvolvedObject? DwaInvolvedObject { get; set; }

        public virtual Product? DwaProduct { get; set; }

        public virtual ReportingForm? DwaReportingForm { get; set; }

        public virtual WorkActivity DwaWorkActivity { get; set; } = null!;

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<TimeSheet> TimeSheets { get; } = new List<TimeSheet>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLines { get; } = new List<WorkingOrderLine>();
    }
}