namespace CED.Data.Entities
{
    public class InvolvedObjectsView
    {
        public Guid Id { get; set; }

        public Guid? DossierPartyId { get; set; }

        public Guid DossierId { get; set; }

        public string? InvolvedObjectCode { get; set; }

        public string? InvolvedObjectName { get; set; }

        public string? VehicleLicensePlate { get; set; }

        public string? VehicleLicensePlateCountryCode { get; set; }

        public string? VehicleBrand { get; set; }

        public string? VehicleModel { get; set; }

        public string? TypeVehicle { get; set; }

        public string? GreencardNumber { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public string? InsurancePolicyNumber { get; set; }

        public int SequenceNumber { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}