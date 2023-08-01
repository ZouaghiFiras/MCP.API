namespace CED.Data.Entities
{
    public class DossierLine
    {
        public Guid DolId { get; set; }

        public byte[] DolTimeStamp { get; set; } = null!;

        public Guid DolDossierId { get; set; }

        public short? DolNumber { get; set; }

        public string DolDescription { get; set; } = null!;

        public Guid? DolReparActionTypeId { get; set; }

        public Guid? DolStatus { get; set; }

        public bool DolCanceled { get; set; }

        public string? DolPriority { get; set; }

        public DateTime DolCreatedDate { get; set; }

        public string? DolCreatedBy { get; set; }

        public DateTime DolLastModifiedDate { get; set; }

        public string? DolLastModifiedBy { get; set; }

        public Guid? DolSkillId { get; set; }

        public virtual Dossier DolDossier { get; set; } = null!;

        public virtual Skill? DolSkill { get; set; }

        public virtual ICollection<RepairOrderLine> RepairOrderLines { get; } = new List<RepairOrderLine>();
    }
}