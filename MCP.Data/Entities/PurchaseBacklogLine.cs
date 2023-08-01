namespace CED.Data.Entities
{
    public class PurchaseBacklogLine
    {
        public Guid PglId { get; set; }

        public byte[] PglTimeStamp { get; set; } = null!;

        public Guid PglPurchaseBacklogId { get; set; }

        public int? PglLineNumber { get; set; }

        public string? PglDescription { get; set; }

        public string? PglYourReference { get; set; }

        public string? PglOurReference { get; set; }

        public DateTime? PglDeliveryDate { get; set; }

        public string? PglProductCode { get; set; }

        public Guid? PglServiceId { get; set; }

        public double? PglQuantity { get; set; }

        public string? PglUnitOfMeasureId { get; set; }

        public decimal? PglUnitPrice { get; set; }

        public decimal? PglDiscount { get; set; }

        public decimal? PglGrossAmount { get; set; }

        public decimal? PglTaxBase { get; set; }

        public double? PglTaxRate { get; set; }

        public decimal? PglTaxAmount { get; set; }

        public decimal? PglNetAmount { get; set; }

        public bool? PglIsTaxBeforeDiscount { get; set; }

        public bool? PglIsCredit { get; set; }

        public Guid? PglDebitPurchaseBacklogLineId { get; set; }

        public bool? PglTaxExempted { get; set; }

        public bool? PglTaxReversedCharge { get; set; }

        public bool? PglTaxImport { get; set; }

        public string? PglDossierNumber { get; set; }

        public Guid? PglDossierId { get; set; }

        public Guid? PglDossierAssignmentId { get; set; }

        public Guid? PglDossierPartyId { get; set; }

        public Guid? PglAssistancePlanId { get; set; }

        public string? PglTaxCountryCode { get; set; }

        public bool PglIsContinuousPost { get; set; }

        public DateTime PglCreatedDate { get; set; }

        public string? PglCreatedBy { get; set; }

        public DateTime PglLastModifiedDate { get; set; }

        public string? PglLastModifiedBy { get; set; }

        public Guid? PglWorkingOrderId { get; set; }

        public virtual ICollection<PurchaseBacklogLine> InversePglDebitPurchaseBacklogLine { get; } =
            new List<PurchaseBacklogLine>();

        public virtual AssistancePlan? PglAssistancePlan { get; set; }

        public virtual PurchaseBacklogLine? PglDebitPurchaseBacklogLine { get; set; }

        public virtual Dossier? PglDossier { get; set; }

        public virtual DossierAssignment? PglDossierAssignment { get; set; }

        public virtual DossierParty? PglDossierParty { get; set; }

        public virtual PurchaseBacklog PglPurchaseBacklog { get; set; } = null!;

        public virtual Service? PglService { get; set; }

        public virtual UnitOfMeasure? PglUnitOfMeasure { get; set; }

        public virtual WorkingOrder? PglWorkingOrder { get; set; }
    }
}