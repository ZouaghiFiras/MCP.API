namespace CED.Data.Entities
{
    public class DossierPartyObjectsView
    {
        public Guid Id { get; set; }

        public Guid DossierPartyId { get; set; }

        public Guid DossierId { get; set; }

        public string? DossierNumber { get; set; }

        public Guid? InvolvedObjectId { get; set; }

        public string? InvolvedObjectCode { get; set; }

        public string? InvolvedObjectName { get; set; }

        public Guid? InvolvedPartyId { get; set; }

        public string InvolvedPartyRoleCode { get; set; } = null!;

        public string InvolvedPartyRoleName { get; set; } = null!;

        public string? InvolvedPartyFullName { get; set; }

        public string? InvolvedPartyFullAddress { get; set; }

        public string? InvolvedPartyPostalcode { get; set; }

        public string? InvolvedPartyHouseNumber { get; set; }

        public string? InvolvedPartyHouseNumberAddition { get; set; }

        public string? InvolvedPartyPhoneNumber { get; set; }

        public DateTime? InvolvedPartyDateOfBirth { get; set; }

        public string? VehicleLicensePlate { get; set; }

        public string? VehicleLicensePlateCountryCode { get; set; }

        public string? VehicleBrand { get; set; }

        public string? VehicleModel { get; set; }

        public string? TypeVehicle { get; set; }

        public string? GreencardNumber { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public string? InsuranceProductType { get; set; }

        public string? InsurancePolicyFreeField1 { get; set; }

        public string? InsurancePolicyFreeField2 { get; set; }

        public string? InsurancePolicyFreeField3 { get; set; }

        public string? InsurancePolicyFreeField4 { get; set; }

        public string? DossierInsureeFullName { get; set; }

        public string? DossierInsureePostalCode { get; set; }

        public string? DossierInsureeHouseNumber { get; set; }

        public string? DossierInsureeHouseNumberAddition { get; set; }

        public DateTime? IncidentDate { get; set; }

        public string? AgentCode { get; set; }

        public string? AgentName { get; set; }

        public string? AgentPhoneNumber { get; set; }

        public string? MandateCode { get; set; }

        public string? MandateCrwamCode { get; set; }

        public string? MandateName { get; set; }

        public string? MandatePhoneNumber { get; set; }

        public string? InsurerCode { get; set; }

        public string? InsurerName { get; set; }

        public string? InsurerPhoneNumber { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}