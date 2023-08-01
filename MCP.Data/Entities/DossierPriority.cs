namespace CED.Data.Entities
{
    public class DossierPriority
    {
        public Guid DopId { get; set; }

        public byte[] DopTimeStamp { get; set; } = null!;

        public string DopCode { get; set; } = null!;

        public string? DopShortName { get; set; }

        public string DopLongName { get; set; } = null!;

        public bool DopInactive { get; set; }

        public DateTime DopCreatedDate { get; set; }

        public string? DopCreatedBy { get; set; }

        public DateTime DopLastModifiedDate { get; set; }

        public string? DopLastModifiedBy { get; set; }

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();
    }
}