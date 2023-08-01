namespace CED.Data.Entities
{
    public class ExternalMaterial
    {
        public Guid EmId { get; set; }

        public byte[] EmTimeStamp { get; set; } = null!;

        public string EmCode { get; set; } = null!;

        public string? EmShortName { get; set; }

        public string EmLongName { get; set; } = null!;

        public bool EmInactive { get; set; }

        public Guid? EmLocalizableEntryId { get; set; }

        public DateTime EmCreatedDate { get; set; }

        public string? EmCreatedBy { get; set; }

        public DateTime EmLastModifiedDate { get; set; }

        public string? EmLastModifiedBy { get; set; }

        public virtual LocalizableEntry? EmLocalizableEntry { get; set; }

        public virtual ICollection<InsuranceObjectExternalMaterial> InsuranceObjectExternalMaterials { get; } =
            new List<InsuranceObjectExternalMaterial>();

        public virtual ICollection<Property> Properties { get; } = new List<Property>();
    }
}