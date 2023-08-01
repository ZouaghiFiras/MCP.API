namespace CED.Data.Entities
{
    public class DossierWorkActivityTrigger
    {
        public Guid DwatId { get; set; }

        public byte[] DwatTimeStamp { get; set; } = null!;

        public string DwatDossierWorkActivityTypeId { get; set; } = null!;

        public DateTime DwatCreatedDate { get; set; }

        public string? DwatCreatedBy { get; set; }

        public DateTime DwatLastModifiedDate { get; set; }

        public string? DwatLastModifiedBy { get; set; }

        public short? DwatTriggerSequence { get; set; }

        public virtual DossierWorkActivity Dwat { get; set; } = null!;

        public virtual DossierWorkActivityTriggerType DwatDossierWorkActivityType { get; set; } = null!;
    }
}