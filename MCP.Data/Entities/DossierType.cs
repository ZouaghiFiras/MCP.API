namespace CED.Data.Entities
{
    public class DossierType
    {
        public short DotId { get; set; }

        public byte[] DotTimeStamp { get; set; } = null!;

        public string DotCode { get; set; } = null!;

        public string? DotShortName { get; set; }

        public string DotLongName { get; set; } = null!;

        public bool DotInactive { get; set; }

        public DateTime DotCreatedDate { get; set; }

        public string? DotCreatedBy { get; set; }

        public DateTime DotLastModifiedDate { get; set; }

        public string? DotLastModifiedBy { get; set; }

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();
    }
}