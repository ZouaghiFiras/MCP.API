namespace CED.Data.Entities
{
    public class UnitOfMeasure
    {
        public string UomId { get; set; } = null!;

        public byte[] UomTimeStamp { get; set; } = null!;

        public string UomName { get; set; } = null!;

        public bool UomInactive { get; set; }

        public Guid? UomLocalizableEntryId { get; set; }

        public DateTime UomCreatedDate { get; set; }

        public string? UomCreatedBy { get; set; }

        public DateTime UomLastModifiedDate { get; set; }

        public string? UomLastModifiedBy { get; set; }

        public Guid? UomUnitOfMeasureTypesId { get; set; }

        public virtual ICollection<AssistancePlanLine> AssistancePlanLines { get; } = new List<AssistancePlanLine>();

        public virtual ICollection<HourlyFeeAgreement> HourlyFeeAgreements { get; } = new List<HourlyFeeAgreement>();

        public virtual ICollection<PurchaseBacklogLine> PurchaseBacklogLines { get; } = new List<PurchaseBacklogLine>();

        public virtual ICollection<PurchaseInvoiceLine> PurchaseInvoiceLines { get; } = new List<PurchaseInvoiceLine>();

        public virtual ICollection<PurchaseOrderLine> PurchaseOrderLines { get; } = new List<PurchaseOrderLine>();

        public virtual ICollection<SalesInvoiceLine> SalesInvoiceLines { get; } = new List<SalesInvoiceLine>();

        public virtual ICollection<SalesOrderLine> SalesOrderLines { get; } = new List<SalesOrderLine>();

        public virtual ICollection<SalesOrderToTimeSheetMapping> SalesOrderToTimeSheetMappings { get; } =
            new List<SalesOrderToTimeSheetMapping>();

        public virtual ICollection<TimeSheet> TimeSheets { get; } = new List<TimeSheet>();

        public virtual LocalizableEntry? UomLocalizableEntry { get; set; }

        public virtual UnitOfMeasureType? UomUnitOfMeasureTypes { get; set; }

        public virtual ICollection<VolumeSalesAgreement> VolumeSalesAgreements { get; } =
            new List<VolumeSalesAgreement>();

        public virtual ICollection<WorkingOrderLineCoverage> WorkingOrderLineCoverages { get; } =
            new List<WorkingOrderLineCoverage>();
    }
}