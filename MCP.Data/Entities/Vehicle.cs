namespace CED.Data.Entities
{
    public class Vehicle
    {
        public Guid VehId { get; set; }

        public byte[] VehTimeStamp { get; set; } = null!;

        public string? VehOwnerVehicle { get; set; }

        public string? VehCommercialDescription { get; set; }

        public bool? VehIsMeldcodeCorrect { get; set; }

        public string? VehChassisNumber { get; set; }

        public string? VehLicensePlate { get; set; }

        public string? VehLicensePlateUnformatted { get; set; }

        public string? VehLicenseCountryCode { get; set; }

        public string? VehBrand { get; set; }

        public string? VehModel { get; set; }

        public string? VehTypeVehicle { get; set; }

        public string? VehFirstColor { get; set; }

        public string? VehSecondColor { get; set; }

        public int? VehSeats { get; set; }

        public int? VehStandingPlaces { get; set; }

        public string? VehPrimaryFuelTypeCode { get; set; }

        public string? VehSecondaryFuelTypeCode { get; set; }

        public Guid? VehPrimaryFuelTypeId { get; set; }

        public Guid? VehSecondaryFuelTypeId { get; set; }

        public int? VehCylinders { get; set; }

        public int? VehEngineCapacity { get; set; }

        public int? VehMassEmptyVehicle { get; set; }

        public int? VehLoadBearingCapacity { get; set; }

        public int? VehMaximumPermissibleMass { get; set; }

        public int? VehMassRoadWorthy { get; set; }

        public int? VehMaximumTowableMassUnbraked { get; set; }

        public int? VehMaximumTowableMassBraked { get; set; }

        public int? VehMaximumTowableMassTrailerBraked { get; set; }

        public int? VehMaximumTowableMassAutonomousBraked { get; set; }

        public int? VehMaximumTowableMassCenterAxisBraked { get; set; }

        public DateTime? VehFirstRegistration { get; set; }

        public DateTime? VehFirstReleaseNetherlands { get; set; }

        public DateTime? VehLastAscription { get; set; }

        public DateTime? VehMoTexpiry { get; set; }

        public bool? VehIsParallelImport { get; set; }

        public Guid? VehVehicleKindId { get; set; }

        public int? VehVersionSequenceNumber { get; set; }

        public int? VehDoors { get; set; }

        public string? VehBody { get; set; }

        public string? VehClassification { get; set; }

        public int? VehWheels { get; set; }

        public int? VehPowerKw { get; set; }

        public double? VehPowerMoped { get; set; }

        public int? VehMaximumSpeed { get; set; }

        public string? VehEmissionCode { get; set; }

        public bool? VehHasG3installation { get; set; }

        public int? VehBpm { get; set; }

        public bool? VehIsObligationHolder { get; set; }

        public bool? VehIsWamInsured { get; set; }

        public double? VehWheelBase { get; set; }

        public string? VehMotorCode { get; set; }

        public decimal? VehListPrice { get; set; }

        public bool? VehIsTaxi { get; set; }

        public string? VehOvsClearinghuisCommunityAddress { get; set; }

        public string? VehOvsCode { get; set; }

        public string? VehOvsPercentageLiability { get; set; }

        public string? VehOvsDescription { get; set; }

        public string? VehDamageLocationPoint { get; set; }

        public string? VehGreenCardNumber { get; set; }

        public string? VehInsurancePolicyNumber { get; set; }

        public int? VehMileageKm { get; set; }

        public bool? VehIsReplacement { get; set; }

        public DateTime VehCreatedDate { get; set; }

        public string? VehCreatedBy { get; set; }

        public DateTime VehLastModifiedDate { get; set; }

        public string? VehLastModifiedBy { get; set; }

        public virtual InvolvedObject Veh { get; set; } = null!;

        public virtual FuelType? VehPrimaryFuelType { get; set; }

        public virtual FuelType? VehSecondaryFuelType { get; set; }
    }
}