namespace CED.Data.Entities
{
    public class InvolvedCoverageObjectsView
    {
        public Guid Id { get; set; }

        public Guid? DossierPartyId { get; set; }

        public Guid DossierId { get; set; }

        public string? VehicleLicensePlate { get; set; }

        public string? VehicleLicensePlateCountryCode { get; set; }

        public string? VehicleBrand { get; set; }

        public string? VehicleModel { get; set; }

        public string? TypeVehicle { get; set; }

        public string? GreencardNumber { get; set; }

        public string? InvolvedPartyRoleCode { get; set; }
    }
}