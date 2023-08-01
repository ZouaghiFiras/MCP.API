namespace CED.Data.Entities
{
    public class FuelType
    {
        public Guid FtId { get; set; }

        public byte[] FtTimeStamp { get; set; } = null!;

        public string FtCode { get; set; } = null!;

        public string? FtShortName { get; set; }

        public string FtLongName { get; set; } = null!;

        public bool FtInactive { get; set; }

        public Guid? FtLocalizableEntryId { get; set; }

        public DateTime FtCreatedDate { get; set; }

        public string? FtCreatedBy { get; set; }

        public DateTime FtLastModifiedDate { get; set; }

        public string? FtLastModifiedBy { get; set; }

        public virtual LocalizableEntry? FtLocalizableEntry { get; set; }

        public virtual ICollection<Vehicle> VehicleVehPrimaryFuelTypes { get; } = new List<Vehicle>();

        public virtual ICollection<Vehicle> VehicleVehSecondaryFuelTypes { get; } = new List<Vehicle>();
    }
}