namespace CED.Data.Entities
{
    public class Repairer
    {
        public Guid RepId { get; set; }

        public byte[] RepTimeStamp { get; set; } = null!;

        public string? RepExternalCode { get; set; }

        public string? RepCultureCodePreferredLanguage { get; set; }

        public bool? RepInactive { get; set; }

        public DateTime RepCreatedDate { get; set; }

        public string? RepCreatedBy { get; set; }

        public DateTime RepLastModifiedDate { get; set; }

        public string? RepLastModifiedBy { get; set; }

        public virtual OrganizationUnit Rep { get; set; } = null!;

        public virtual ICollection<RepairOrder> RepairOrders { get; } = new List<RepairOrder>();

        public virtual ICollection<RepairerSkill> RepairerSkills { get; } = new List<RepairerSkill>();
    }
}