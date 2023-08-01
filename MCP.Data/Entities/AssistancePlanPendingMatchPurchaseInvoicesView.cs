namespace CED.Data.Entities
{
    public class AssistancePlanPendingMatchPurchaseInvoicesView
    {
        public string? DossieNumber { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierEntrySystem { get; set; }

        public Guid? VehicleId { get; set; }

        public string? VehicleLicensePlate { get; set; }

        public string? VehicleLicensePlateUnformatted { get; set; }

        public string AssistancePlanNumber { get; set; } = null!;

        public Guid AssistancePlanId { get; set; }

        public Guid AssistancePlanLineId { get; set; }

        public string ServiceCode { get; set; } = null!;

        public Guid? MainServiceGroupId { get; set; }

        public Guid? SubServiceGroupId { get; set; }

        public decimal? AssistancePlanLineAmount { get; set; }

        public Guid? PurchaseOrderId { get; set; }

        public string? PurchaseOrderNumber { get; set; }

        public Guid? PurchaseOrderLineId { get; set; }

        public int? PurchaseOrderLineNumber { get; set; }

        public int AssistancePlanLineNumber { get; set; }

        public bool IsCostOfSales { get; set; }

        public bool? Inactive { get; set; }

        public string? AssistancePlanDropOffLocationCity { get; set; }

        public string? AssistancePlanDropOffLocationCountryCode { get; set; }

        public string? AssistancePlanPickUpLocationCity { get; set; }

        public string? AssistancePlanPickUpLocationCountryCode { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}