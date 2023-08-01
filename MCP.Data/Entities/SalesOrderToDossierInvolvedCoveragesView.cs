namespace CED.Data.Entities
{
    public class SalesOrderToDossierInvolvedCoveragesView
    {
        public Guid Id { get; set; }

        public string PolicyNumber { get; set; } = null!;

        public bool? Insured { get; set; }

        public string? InsuranceCompanyName { get; set; }

        public string? MandateName { get; set; }

        public Guid? ChargedExpensesRecipientId { get; set; }

        public string? ChargedExpensesRecipientCode { get; set; }

        public string? ChargedExpensesRecipientName { get; set; }

        public Guid? FeeRecipientId { get; set; }

        public string? FeeRecipientCode { get; set; }

        public string? FeeRecipientName { get; set; }

        public string? ClientCode { get; set; }

        public string? ClientName { get; set; }

        public string? ClientStreetName { get; set; }

        public string? ClientHouseNumber { get; set; }

        public string? ClientPostalCode { get; set; }

        public string? ClientCity { get; set; }

        public string? ClientCountry { get; set; }

        public string? ClientVatNumber { get; set; }

        public string? ClientChamberOfCommerce { get; set; }

        public string? ClientEmail { get; set; }

        public Guid SalesOrderId { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[] TimeStamp { get; set; } = null!;
    }
}