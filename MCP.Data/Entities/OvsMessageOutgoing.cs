namespace CED.Data.Entities
{
    public class OvsMessageOutgoing
    {
        public Guid OmoId { get; set; }

        public byte[] OmoTimeStamp { get; set; } = null!;

        public Guid OmoOvsRegresId { get; set; }

        public string? OmoOvsMessageTypeId { get; set; }

        public string OmoInsuredOvsCodeId { get; set; } = null!;

        public string OmoCrcommunityAdress { get; set; } = null!;

        public string? OmoLicensePlateInsured { get; set; }

        public string? OmoLicensePlateCounterParty { get; set; }

        public DateTime? OmoSendDate { get; set; }

        public string? OmoErrorCode { get; set; }

        public string? OmoErrorMessage { get; set; }

        public Guid? OmoOvsMessageStatusId { get; set; }

        public string? OmoOvsLiabilityPercentageId { get; set; }

        public DateTime OmoCreatedDate { get; set; }

        public string? OmoCreatedBy { get; set; }

        public DateTime OmoLastModifiedDate { get; set; }

        public string? OmoLastModifiedBy { get; set; }

        public virtual OvsCode OmoInsuredOvsCode { get; set; } = null!;

        public virtual OvsLiabilityPercentage? OmoOvsLiabilityPercentage { get; set; }

        public virtual OvsMessageStatus? OmoOvsMessageStatus { get; set; }

        public virtual OvsMessageType? OmoOvsMessageType { get; set; }

        public virtual OvsRegre OmoOvsRegres { get; set; } = null!;

        public virtual ICollection<OvsPayment> OvsPayments { get; } = new List<OvsPayment>();
    }
}