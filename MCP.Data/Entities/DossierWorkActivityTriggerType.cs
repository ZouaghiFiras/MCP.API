namespace CED.Data.Entities
{
    public class DossierWorkActivityTriggerType
    {
        public string DwattId { get; set; } = null!;

        public byte[] DwattTimeStamp { get; set; } = null!;

        public string DwattName { get; set; } = null!;

        public bool DwattInactive { get; set; }

        public DateTime DwattCreatedDate { get; set; }

        public string? DwattCreatedBy { get; set; }

        public DateTime DwattLastModifiedDate { get; set; }

        public string? DwattLastModifiedBy { get; set; }

        public virtual ICollection<DossierWorkActivityTrigger> DossierWorkActivityTriggers { get; } =
            new List<DossierWorkActivityTrigger>();
    }
}