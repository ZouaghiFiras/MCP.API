namespace CED.Data.Entities
{
    public class DossierPartyRole
    {
        public Guid DprId { get; set; }

        public byte[] DprTimeStamp { get; set; } = null!;

        public Guid DprDossierPartyId { get; set; }

        public Guid DprRoleCodeId { get; set; }

        public DateTime DprCreatedDate { get; set; }

        public string? DprCreatedBy { get; set; }

        public DateTime DprLastModifiedDate { get; set; }

        public string? DprLastModifiedBy { get; set; }

        public virtual DossierParty DprDossierParty { get; set; } = null!;

        public virtual RoleCode DprRoleCode { get; set; } = null!;
    }
}