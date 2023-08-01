namespace CED.Data.Entities
{
    public class ServiceApplication
    {
        public Guid SraId { get; set; }

        public byte[] SraTimeStamp { get; set; } = null!;

        public Guid SraServiceId { get; set; }

        public Guid SraApplicationId { get; set; }

        public bool SraInactive { get; set; }

        public DateTime SraCreatedDate { get; set; }

        public string? SraCreatedBy { get; set; }

        public DateTime SraLastModifiedDate { get; set; }

        public string? SraLastModifiedBy { get; set; }

        public virtual Application SraApplication { get; set; } = null!;

        public virtual Service SraService { get; set; } = null!;
    }
}