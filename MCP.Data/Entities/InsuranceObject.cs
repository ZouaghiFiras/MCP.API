namespace CED.Data.Entities
{
    public class InsuranceObject
    {
        public Guid IoId { get; set; }

        public byte[] IoTimeStamp { get; set; } = null!;

        public string IoCode { get; set; } = null!;

        public string? IoShortName { get; set; }

        public string IoLongName { get; set; } = null!;

        public bool IoInactive { get; set; }

        public Guid? IoLocalizableEntryId { get; set; }

        public DateTime IoCreatedDate { get; set; }

        public string? IoCreatedBy { get; set; }

        public DateTime IoLastModifiedDate { get; set; }

        public string? IoLastModifiedBy { get; set; }

        public Guid? IoInsuranceObjectTypeId { get; set; }

        public bool IoIsMain { get; set; }

        public bool IoIsPrivate { get; set; }

        public bool IoIsBusiness { get; set; }

        public string? IoObjectClassificationId { get; set; }

        public virtual ICollection<ContractInsuranceObject> ContractInsuranceObjects { get; } =
            new List<ContractInsuranceObject>();

        public virtual ICollection<InsuranceObjectDamageLocation> InsuranceObjectDamageLocations { get; } =
            new List<InsuranceObjectDamageLocation>();

        public virtual ICollection<InsuranceObjectExternalMaterial> InsuranceObjectExternalMaterials { get; } =
            new List<InsuranceObjectExternalMaterial>();

        public virtual ICollection<InsuranceObjectHierarchy> InsuranceObjectHierarchies { get; } =
            new List<InsuranceObjectHierarchy>();

        public virtual ICollection<InsuranceObjectRoofCovering> InsuranceObjectRoofCoverings { get; } =
            new List<InsuranceObjectRoofCovering>();

        public virtual ICollection<InvolvedObject> InvolvedObjects { get; } = new List<InvolvedObject>();

        public virtual InsuranceObjectType? IoInsuranceObjectType { get; set; }

        public virtual LocalizableEntry? IoLocalizableEntry { get; set; }

        public virtual ObjectClassification? IoObjectClassification { get; set; }

        public virtual ICollection<Model> Models { get; } = new List<Model>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();

        public virtual ICollection<ProductInsuranceObject> ProductInsuranceObjects { get; } =
            new List<ProductInsuranceObject>();
    }
}