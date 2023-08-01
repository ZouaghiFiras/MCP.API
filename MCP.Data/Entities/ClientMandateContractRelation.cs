namespace CED.Data.Entities
{
    public class ClientMandateContractRelation
    {
        public Guid CmcrId { get; set; }

        public Guid CmcrClientMandateId { get; set; }

        public Guid? CmcrFeeSettlementId { get; set; }

        public bool CmcrUseClientContract { get; set; }

        public byte[] CmcrTimeStamp { get; set; } = null!;

        public string? CmcrCreatedBy { get; set; }

        public DateTime CmcrCreatedDate { get; set; }

        public string? CmcrLastModifiedBy { get; set; }

        public DateTime CmcrLastModifiedDate { get; set; }

        public virtual ClientMandate CmcrClientMandate { get; set; } = null!;

        public virtual FeeSettlement? CmcrFeeSettlement { get; set; }
    }
}