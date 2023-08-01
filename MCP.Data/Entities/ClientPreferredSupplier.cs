namespace CED.Data.Entities
{
    public class ClientPreferredSupplier
    {
        public Guid CpsId { get; set; }

        public byte[] CpsTimeStamp { get; set; } = null!;

        public Guid CpsClientId { get; set; }

        public Guid CpsSupplierId { get; set; }

        public bool? CpsInactive { get; set; }

        public DateTime CpsCreatedDate { get; set; }

        public string? CpsCreatedBy { get; set; }

        public DateTime CpsLastModifiedDate { get; set; }

        public string? CpsLastModifiedBy { get; set; }

        public virtual Client CpsClient { get; set; } = null!;

        public virtual Supplier CpsSupplier { get; set; } = null!;
    }
}