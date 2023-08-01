namespace CED.Data.Entities
{
    public class PurchaseBacklogsNextToProcessView
    {
        public Guid Id { get; set; }

        public int? Priority { get; set; }

        public string? PurchaseBacklogStatusCode { get; set; }

        public string? InUseBy { get; set; }

        public string? EntrySystem { get; set; }

        public bool IsMedicalDossier { get; set; }

        public DateTime ReceivedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}