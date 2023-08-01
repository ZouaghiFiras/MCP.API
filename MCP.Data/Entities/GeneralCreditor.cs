namespace CED.Data.Entities
{
    public class GeneralCreditor
    {
        public Guid GcdId { get; set; }

        public byte[] GcdTimeStamp { get; set; } = null!;

        public Guid GcdCreditorId { get; set; }

        public DateTime GcdCreatedDate { get; set; }

        public string? GcdCreatedBy { get; set; }

        public DateTime GcdLastModifiedDate { get; set; }

        public string? GcdLastModifiedBy { get; set; }

        public virtual Creditor GcdCreditor { get; set; } = null!;
    }
}