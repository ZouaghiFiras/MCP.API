namespace CED.Data.Entities
{
    public class DossierContactPerson
    {
        public Guid DcpId { get; set; }

        public byte[] DcpTimeStamp { get; set; } = null!;

        public Guid DcpDossierId { get; set; }

        public Guid? DcpContactPersonId { get; set; }

        public Guid DcpContactPersonTypeId { get; set; }

        public DateTime DcpEffectiveDate { get; set; }

        public DateTime? DcpTerminationDate { get; set; }

        public DateTime DcpCreatedDate { get; set; }

        public string? DcpCreatedBy { get; set; }

        public DateTime DcpLastModifiedDate { get; set; }

        public string? DcpLastModifiedBy { get; set; }

        public virtual ContactPerson? DcpContactPerson { get; set; }

        public virtual ContactPersonType DcpContactPersonType { get; set; } = null!;

        public virtual Dossier DcpDossier { get; set; } = null!;
    }
}