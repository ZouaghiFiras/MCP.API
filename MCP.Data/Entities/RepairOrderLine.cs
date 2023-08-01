namespace CED.Data.Entities
{
    public class RepairOrderLine
    {
        public Guid RolId { get; set; }

        public byte[] RolTimeStamp { get; set; } = null!;

        public Guid RolRepairOrderId { get; set; }

        public short RolNumber { get; set; }

        public Guid RolDossierLineId { get; set; }

        public DateTime RolCreatedDate { get; set; }

        public string? RolCreatedBy { get; set; }

        public DateTime RolLastModifiedDate { get; set; }

        public string? RolLastModifiedBy { get; set; }

        public virtual DossierLine RolDossierLine { get; set; } = null!;

        public virtual RepairOrder RolRepairOrder { get; set; } = null!;
    }
}