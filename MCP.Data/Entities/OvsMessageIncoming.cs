namespace CED.Data.Entities
{
    public class OvsMessageIncoming
    {
        public Guid OmiId { get; set; }

        public byte[] OmiTimeStamp { get; set; } = null!;

        public Guid OmiOvsRegresId { get; set; }

        public string? OmiOvsMessageTypeId { get; set; }

        public string OmiCounterPartyOvsCodeId { get; set; } = null!;

        public string OmiCrcommunityAdress { get; set; } = null!;

        public string? OmiReferenceNumberCounterParty { get; set; }

        public string? OmiLicensePlateCounterParty { get; set; }

        public string? OmiLicensePlateInsured { get; set; }

        public DateTime? OmiReceivedDate { get; set; }

        public string? OmiErrorCode { get; set; }

        public string? OmiErrorMessage { get; set; }

        public Guid? OmiOvsMessageStatusId { get; set; }

        public string? OmiOvsLiabilityPercentageId { get; set; }

        public string? OmiOvsDeregistrationReasonId { get; set; }

        public DateTime OmiCreatedDate { get; set; }

        public string? OmiCreatedBy { get; set; }

        public DateTime OmiLastModifiedDate { get; set; }

        public string? OmiLastModifiedBy { get; set; }

        public virtual OvsCode OmiCounterPartyOvsCode { get; set; } = null!;

        public virtual OvsDeregistrationReason? OmiOvsDeregistrationReason { get; set; }

        public virtual OvsLiabilityPercentage? OmiOvsLiabilityPercentage { get; set; }

        public virtual OvsMessageStatus? OmiOvsMessageStatus { get; set; }

        public virtual OvsMessageType? OmiOvsMessageType { get; set; }

        public virtual OvsRegre OmiOvsRegres { get; set; } = null!;

        public virtual ICollection<OvsPayment> OvsPayments { get; } = new List<OvsPayment>();
    }
}