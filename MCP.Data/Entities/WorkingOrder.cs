namespace CED.Data.Entities
{
    public class WorkingOrder
    {
        public Guid WoId { get; set; }

        public byte[] WoTimeStamp { get; set; } = null!;

        public string? WoWorkingOrderNumber { get; set; }

        public Guid? WoEmployeeId { get; set; }

        public Guid WoDossierId { get; set; }

        public Guid? WoDossierAssignmentId { get; set; }

        public Guid? WoMainDossierPartyId { get; set; }

        public Guid? WoFacilityDossierPartyId { get; set; }

        public DateTime WoCreatedDate { get; set; }

        public string? WoCreatedBy { get; set; }

        public DateTime WoLastModifiedDate { get; set; }

        public string? WoLastModifiedBy { get; set; }

        public Guid? WoWorkingOrderTypeId { get; set; }

        public Guid? WoWorkingOrderSubTypeId { get; set; }

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseBacklogWorkingOrder> PurchaseBacklogWorkingOrders { get; } =
            new List<PurchaseBacklogWorkingOrder>();

        public virtual ICollection<PurchaseBacklog> PurchaseBacklogs { get; } = new List<PurchaseBacklog>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseInvoice> PurchaseInvoices { get; } = new List<PurchaseInvoice>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual Dossier WoDossier { get; set; } = null!;

        public virtual DossierAssignment? WoDossierAssignment { get; set; }

        public virtual Employee? WoEmployee { get; set; }

        public virtual WorkingOrderSubType? WoWorkingOrderSubType { get; set; }

        public virtual WorkingOrderType? WoWorkingOrderType { get; set; }

        public virtual WorkingOrderCurrentStatus? WorkingOrderCurrentStatus { get; set; }

        public virtual ICollection<WorkingOrderInvolvedObject> WorkingOrderInvolvedObjects { get; } =
            new List<WorkingOrderInvolvedObject>();

        public virtual ICollection<WorkingOrderLine> WorkingOrderLines { get; } = new List<WorkingOrderLine>();

        public virtual ICollection<WorkingOrderLogHistory> WorkingOrderLogHistories { get; } =
            new List<WorkingOrderLogHistory>();

        public virtual ICollection<WorkingOrderNote> WorkingOrderNotes { get; } = new List<WorkingOrderNote>();

        public virtual ICollection<WorkingOrderParty> WorkingOrderParties { get; } = new List<WorkingOrderParty>();

        public virtual ICollection<WorkingOrderStatusHistory> WorkingOrderStatusHistories { get; } =
            new List<WorkingOrderStatusHistory>();

        public virtual ICollection<WorkingOrderVisitInformation> WorkingOrderVisitInformations { get; } =
            new List<WorkingOrderVisitInformation>();
    }
}