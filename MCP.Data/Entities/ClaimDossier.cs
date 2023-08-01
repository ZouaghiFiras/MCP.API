namespace CED.Data.Entities
{
    public class ClaimDossier
    {
        public Guid CldId { get; set; }

        public byte[] CldTimeStamp { get; set; } = null!;

        public Guid? CldInsurancePolicyId { get; set; }

        public string? CldIncidentNumberInsurer { get; set; }

        public string? CldIncidentNumberCounterParty { get; set; }

        public DateTime? CldIncidentDate { get; set; }

        public string? CldIncidentStreet { get; set; }

        public string? CldIncidentCity { get; set; }

        public bool? CldIsOvsDossier { get; set; }

        public bool? CldIsOvsXmlInterface { get; set; }

        public bool? CldIsWaarborgfonds { get; set; }

        public string? CldCoverage { get; set; }

        public string? CldDamageType { get; set; }

        public string? CldCollisionWith { get; set; }

        public string? CldObjectStolen { get; set; }

        public string? CldCause { get; set; }

        public Guid? CldLiablePartyId { get; set; }

        public int? CldLiablePartyProbability { get; set; }

        public string? CldTypeOfRoadInsured { get; set; }

        public string? CldTypeOfRoadOtherParty { get; set; }

        public string? CldDirectionInsured { get; set; }

        public string? CldDirectionOtherParty { get; set; }

        public string? CldActionInsured { get; set; }

        public string? CldActionOtherParty { get; set; }

        public string? CldIndicatorInsured { get; set; }

        public string? CldIndicatorOtherParty { get; set; }

        public double? CldDistanceInsured { get; set; }

        public double? CldDistanceOtherParty { get; set; }

        public int? CldStationaryInsured { get; set; }

        public int? CldStationaryOtherParty { get; set; }

        public string? CldIntersectionInsured { get; set; }

        public string? CldIntersectionOtherParty { get; set; }

        public string? CldOppositeDirectionInsured { get; set; }

        public string? CldOppositeDirectionOtherParty { get; set; }

        public bool? CldHasInjuries { get; set; }

        public decimal? CldDamageAmountEstimate { get; set; }

        public decimal? CldDamageAmountFinal { get; set; }

        public string? CldReportingParty { get; set; }

        public DateTime CldCreatedDate { get; set; }

        public string? CldCreatedBy { get; set; }

        public DateTime CldLastModifiedDate { get; set; }

        public string? CldLastModifiedBy { get; set; }

        public virtual Dossier Cld { get; set; } = null!;

        public virtual InsurancePolicy? CldInsurancePolicy { get; set; }

        public virtual LiableParty? CldLiableParty { get; set; }
    }
}