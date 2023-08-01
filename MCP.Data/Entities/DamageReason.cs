namespace CED.Data.Entities
{
    public class DamageReason
    {
        public Guid DrId { get; set; }

        public byte[] DrTimeStamp { get; set; } = null!;

        public string DrCode { get; set; } = null!;

        public string? DrShortName { get; set; }

        public string DrLongName { get; set; } = null!;

        public bool DrInactive { get; set; }

        public Guid? DrLocalizableEntryId { get; set; }

        public bool DrIsMain { get; set; }

        public DateTime DrCreatedDate { get; set; }

        public string? DrCreatedBy { get; set; }

        public DateTime DrLastModifiedDate { get; set; }

        public string? DrLastModifiedBy { get; set; }

        public virtual ICollection<DamageReasonCause> DamageReasonCauseDrcCauses { get; } =
            new List<DamageReasonCause>();

        public virtual ICollection<DamageReasonCause> DamageReasonCauseDrcMainReasons { get; } =
            new List<DamageReasonCause>();

        public virtual ICollection<DamageReasonCause> DamageReasonCauseDrcSecondaryReasons { get; } =
            new List<DamageReasonCause>();

        public virtual ICollection<DamageReasonCause> DamageReasonCauseDrcTertiaryReasons { get; } =
            new List<DamageReasonCause>();

        public virtual ICollection<DamageReasonRelation> DamageReasonRelationDrhChildDamageReasons { get; } =
            new List<DamageReasonRelation>();

        public virtual ICollection<DamageReasonRelation> DamageReasonRelationDrhParentDamageReasons { get; } =
            new List<DamageReasonRelation>();

        public virtual ICollection<Dossier> DossierDosCauses { get; } = new List<Dossier>();

        public virtual ICollection<Dossier> DossierDosMainReasons { get; } = new List<Dossier>();

        public virtual ICollection<Dossier> DossierDosReasons { get; } = new List<Dossier>();

        public virtual ICollection<Dossier> DossierDosSubReasons { get; } = new List<Dossier>();

        public virtual LocalizableEntry? DrLocalizableEntry { get; set; }

        public virtual ICollection<ProductDamageReason> ProductDamageReasons { get; } = new List<ProductDamageReason>();

        public virtual ICollection<ProductExclusion> ProductExclusions { get; } = new List<ProductExclusion>();
    }
}