namespace CED.Data.Entities
{
    public class ContractParty
    {
        public Guid CopId { get; set; }

        public byte[] CopTimeStamp { get; set; } = null!;

        public string? CopContractNumber { get; set; }

        public bool? CopInactive { get; set; }

        public DateTime CopCreatedDate { get; set; }

        public string? CopCreatedBy { get; set; }

        public DateTime CopLastModifiedDate { get; set; }

        public string? CopLastModifiedBy { get; set; }

        public virtual OrganizationUnit Cop { get; set; } = null!;
    }
}