namespace CED.Data.Entities
{
    public class TimeSheetReasonHistory
    {
        public Guid TsrhId { get; set; }

        public byte[] TsrhTimeStamp { get; set; } = null!;

        public Guid TsrhTimeSheetId { get; set; }

        public Guid TsrhReasonId { get; set; }

        public string? TsrhAdditionalInformation { get; set; }

        public DateTime TsrhCreatedDate { get; set; }

        public string? TsrhCreatedBy { get; set; }

        public DateTime TsrhLastModifiedDate { get; set; }

        public string? TsrhLastModifiedBy { get; set; }

        public decimal TsrhQuantityInvoiceable { get; set; }

        public decimal TsrhQuantity { get; set; }

        public virtual TimeSheet TsrhTimeSheet { get; set; } = null!;
    }
}