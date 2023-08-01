namespace CED.Data.Entities
{
    public class VehiclesView
    {
        public Guid Id { get; set; }

        public string? LicensePlate { get; set; }

        public string? LicensePlateCountryCode { get; set; }

        public string InvolvedObjectCode { get; set; } = null!;

        public string InvolvedObjectName { get; set; } = null!;

        public string? Brand { get; set; }

        public string? Model { get; set; }

        public string? TypeVehicle { get; set; }

        public string? DamageLocationPoint { get; set; }

        public string? GreencardNumber { get; set; }

        public Guid? InvolvedCoverageId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}