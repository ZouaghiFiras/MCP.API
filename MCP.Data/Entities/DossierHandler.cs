namespace CED.Data.Entities
{
    public class DossierHandler
    {
        public Guid DohId { get; set; }

        public byte[] DohTimeStamp { get; set; } = null!;

        public Guid DohDossierId { get; set; }

        public Guid DohEmployeeId { get; set; }

        public DateTime? DohStartDate { get; set; }

        public DateTime DohCreatedDate { get; set; }

        public string? DohCreatedBy { get; set; }

        public DateTime DohLastModifiedDate { get; set; }

        public string? DohLastModifiedBy { get; set; }

        public virtual Dossier DohDossier { get; set; } = null!;
    }
}