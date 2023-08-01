namespace CED.Data.Entities
{
    public class ContractsView
    {
        public Guid Id { get; set; }

        public string? ContractNumber { get; set; }

        public DateTime ContractDate { get; set; }

        public Guid ClientId { get; set; }

        public string ClientCode { get; set; } = null!;

        public string ClientName { get; set; } = null!;

        public Guid ContractLineId { get; set; }

        public int LineNumber { get; set; }

        public DateTime EffectiveDate { get; set; }

        public string CurrencyCode { get; set; } = null!;

        public string ContractDepartment { get; set; } = null!;

        public string ProductCode { get; set; } = null!;

        public string ProductName { get; set; } = null!;

        public string HandlingCountryCode { get; set; } = null!;

        public string HandlingCurrencyCode { get; set; } = null!;

        public short? HandlingTypeId { get; set; }

        public string HandlingTypeName { get; set; } = null!;

        public string HandlingDepartment { get; set; } = null!;

        public int? Partner { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}