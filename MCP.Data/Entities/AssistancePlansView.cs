namespace CED.Data.Entities
{
    public class AssistancePlansView
    {
        public Guid Id { get; set; }

        public string AssistancePlanNumber { get; set; } = null!;

        public Guid AssistancePlanTypeId { get; set; }

        public string AssistancPlanTypeCode { get; set; } = null!;

        public string AssistancPlanTypeName { get; set; } = null!;

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public DateTime StartDate { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public string? LeadCurrencyCode { get; set; }

        public string? ForeignCurrencyCode { get; set; }

        public Guid SupplierId { get; set; }

        public string SupplierCode { get; set; } = null!;

        public string SupplierName { get; set; } = null!;

        public string? SupplierComments { get; set; }

        public Guid? AssistanceExecutorOrganizationUnitId { get; set; }

        public string? AssistanceExecutorCode { get; set; }

        public string AssistanceExecutorName { get; set; } = null!;

        public string? PickupRoadName { get; set; }

        public double? PickupHectometerPost { get; set; }

        public string? PickupHectometerPostAddition { get; set; }

        public string? PickupDirection { get; set; }

        public string? PickupComments { get; set; }

        public string? DropoffRoadName { get; set; }

        public double? DropoffHectometerPost { get; set; }

        public string? DropoffHectometerPostAddition { get; set; }

        public string? DropoffDirection { get; set; }

        public string? DropoffComments { get; set; }

        public string? PickupStreetName { get; set; }

        public string? PickupHouseNo { get; set; }

        public string? PickupHouseNoAddition { get; set; }

        public string? PickupPostalCode { get; set; }

        public string? PickupCity { get; set; }

        public string? PickupProvince { get; set; }

        public string? PickupCountryCode { get; set; }

        public string? DropoffStreetName { get; set; }

        public string? DropoffHouseNo { get; set; }

        public string? DropoffHouseNoAddition { get; set; }

        public string? DropoffPostalCode { get; set; }

        public string? DropoffCity { get; set; }

        public string? DropoffProvince { get; set; }

        public string? DropoffCountryCode { get; set; }

        public bool? ExpectRepairOnSpot { get; set; }

        public bool? RequireDirectTransport { get; set; }

        public string? DistanceComments { get; set; }

        public string? GeneralComments { get; set; }

        public bool? InvoiceRecipientIsLegalEntity { get; set; }

        public Guid? InvoiceRecipientId { get; set; }

        public string? InvoiceRecipientCode { get; set; }

        public string InvoiceRecipientName { get; set; } = null!;

        public string? AssistancePlanStatusCode { get; set; }

        public string? AssistancePlanStatusName { get; set; }

        public string? AssistancePlanStatusChangeReason { get; set; }

        public DateTime? ActivationDate { get; set; }

        public DateTime? ExecutionStartDate { get; set; }

        public DateTime? ExecutionArrivalDate { get; set; }

        public DateTime? ExecutionEndDate { get; set; }

        public bool? LateCancellation { get; set; }

        public string? LicensePlate { get; set; }

        public string? LicensePlateCountryCode { get; set; }

        public Guid? InsurerId { get; set; }

        public int? InvolvedObjectSequenceNumber { get; set; }

        public string? DossierEntrySystem { get; set; }

        public string? AddtionalComment1 { get; set; }

        public string? AddtionalComment2 { get; set; }

        public string? AddtionalComment3 { get; set; }

        public string? AddtionalComment4 { get; set; }

        public Guid DossierPartyId { get; set; }

        public Guid? DossierPartyRoleId { get; set; }

        public string? DossierPartyRoleCode { get; set; }

        public string? DossierPartyRoleName { get; set; }

        public Guid? InvolvedPartyId { get; set; }

        public string? InvolvedPartyFullName { get; set; }

        public string? InvolvedPartyStreetName { get; set; }

        public string? InvolvedPartyHouseNumber { get; set; }

        public string? InvolvedPartyHouseNumberAddition { get; set; }

        public string? InvolvedPartyPostalCode { get; set; }

        public string? InvolvedPartyCity { get; set; }

        public string? InvolvedPartyCountryCode { get; set; }

        public DateTime? InvolvedPartyDateOfBirth { get; set; }

        public byte[] TimeStamp { get; set; } = null!;

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }
    }
}