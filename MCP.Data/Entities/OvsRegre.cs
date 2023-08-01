namespace CED.Data.Entities
{
    public class OvsRegre
    {
        public Guid OvsId { get; set; }

        public byte[] OvsTimeStamp { get; set; } = null!;

        public Guid? OvsDossierPartyId { get; set; }

        public string OvsCrcommunityAdress { get; set; } = null!;

        public DateTime OvsIncidentDateCounterParty { get; set; }

        public decimal? OvsIncidentAmountCounterParty { get; set; }

        public string? OvsPolicyNumberCounterParty { get; set; }

        public string? OvsLicensePlateCounterParty { get; set; }

        public string? OvsDossierNumberCounterParty { get; set; }

        public DateTime? OvsEndDateRegres { get; set; }

        public DateTime? OvsEndDateMatching { get; set; }

        public bool? OvsIsMatchingPossible { get; set; }

        public DateTime OvsCreatedDate { get; set; }

        public string? OvsCreatedBy { get; set; }

        public DateTime OvsLastModifiedDate { get; set; }

        public string? OvsLastModifiedBy { get; set; }

        public virtual DossierParty? OvsDossierParty { get; set; }

        public virtual ICollection<OvsMessageIncoming> OvsMessageIncomings { get; } = new List<OvsMessageIncoming>();

        public virtual ICollection<OvsMessageOutgoing> OvsMessageOutgoings { get; } = new List<OvsMessageOutgoing>();

        public virtual ICollection<OvsPayment> OvsPayments { get; } = new List<OvsPayment>();

        public virtual ICollection<OvsRegresStatus> OvsRegresStatuses { get; } = new List<OvsRegresStatus>();
    }
}