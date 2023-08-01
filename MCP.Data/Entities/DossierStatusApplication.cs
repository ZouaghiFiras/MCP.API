namespace CED.Data.Entities
{
    public class DossierStatusApplication
    {
        public Guid DsaId { get; set; }

        public byte[] DsaTimeStamp { get; set; } = null!;

        public Guid DsaDossierStatusId { get; set; }

        public Guid DsaApplicationId { get; set; }

        public DateTime DsaCreatedDate { get; set; }

        public string? DsaCreatedBy { get; set; }

        public DateTime DsaLastModifiedDate { get; set; }

        public string? DsaLastModifiedBy { get; set; }

        public virtual Application DsaApplication { get; set; } = null!;

        public virtual DossierStatus DsaDossierStatus { get; set; } = null!;
    }
}