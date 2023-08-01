namespace CED.Data.Entities
{
    public class FeeSettlementReportingFormOption
    {
        public Guid FsrId { get; set; }

        public byte[] FsrTimeStamp { get; set; } = null!;

        public Guid FsrFeeSettlementId { get; set; }

        public Guid FsrProductId { get; set; }

        public Guid FsrReportingFormId { get; set; }

        public Guid FsrFeeAgreementId { get; set; }

        public DateTime FsrCreatedDate { get; set; }

        public string? FsrCreatedBy { get; set; }

        public DateTime FsrLastModifiedDate { get; set; }

        public string? FsrLastModifiedBy { get; set; }

        public virtual FeeAgreement FsrFeeAgreement { get; set; } = null!;

        public virtual FeeSettlement FsrFeeSettlement { get; set; } = null!;

        public virtual Product FsrProduct { get; set; } = null!;

        public virtual ReportingForm FsrReportingForm { get; set; } = null!;
    }
}