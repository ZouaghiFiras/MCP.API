namespace CED.Data.Entities
{
    public class DossierAuthorization
    {
        public Guid DauId { get; set; }

        public byte[] DauTimeStamp { get; set; } = null!;

        public Guid DauDossierId { get; set; }

        public string DauRequiredAutorizationRoleId { get; set; } = null!;

        public DateTime DauCreatedDate { get; set; }

        public string? DauCreatedBy { get; set; }

        public DateTime DauLastModifiedDate { get; set; }

        public string? DauLastModifiedBy { get; set; }

        public virtual Dossier DauDossier { get; set; } = null!;

        public virtual AuthorizationRole DauRequiredAutorizationRole { get; set; } = null!;

        public virtual ICollection<DossierApproval> DossierApprovals { get; } = new List<DossierApproval>();
    }
}