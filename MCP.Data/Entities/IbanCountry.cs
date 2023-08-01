namespace CED.Data.Entities
{
    public class IbanCountry
    {
        public string IbcId { get; set; } = null!;

        public byte[] IbcTimeStamp { get; set; } = null!;

        public short? IbcIbanLength { get; set; }

        public DateTime IbcCreatedDate { get; set; }

        public string? IbcCreatedBy { get; set; }

        public DateTime IbcLastModifiedDate { get; set; }

        public string? IbcLastModifiedBy { get; set; }

        public virtual Country Ibc { get; set; } = null!;
    }
}