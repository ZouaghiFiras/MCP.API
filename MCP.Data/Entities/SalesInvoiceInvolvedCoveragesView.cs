namespace CED.Data.Entities
{
    public class SalesInvoiceInvolvedCoveragesView
    {
        public Guid? Id { get; set; }

        public Guid SalesInvoiceId { get; set; }

        public string? PolicyNumber { get; set; }

        public bool? Insured { get; set; }

        public Guid? InsurerId { get; set; }

        public string? InsurerRdwCode { get; set; }

        public string? InsurerCode { get; set; }

        public string? InsuranceProductType { get; set; }

        public string? InsuranceCompanyName { get; set; }

        public string? MandateRdwCode { get; set; }

        public string? MandateCrWamCode { get; set; }

        public Guid? MandateId { get; set; }

        public string? MandateName { get; set; }

        public string? MandatePhoneNumber { get; set; }

        public string? AgentName { get; set; }

        public string? AgentPhoneNumber { get; set; }

        public Guid? ChargedExpensesRecipientId { get; set; }

        public string? ChargedExpensesRecipientCode { get; set; }

        public string? ChargedExpensesRecipientName { get; set; }

        public Guid? FeeRecipientId { get; set; }

        public string? FeeRecipientCode { get; set; }

        public string? FeeRecipientName { get; set; }

        public Guid? ClientId { get; set; }

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

        public string SalesOrderNumber { get; set; } = null!;

        public Guid? CoverageProductId { get; set; }

        public string? CoverageProductCode { get; set; }

        public string? CovergeProductName { get; set; }

        public string? CoverageProductTypeCode { get; set; }

        public string? InsuranceCoverageTypeCode { get; set; }

        public Guid? DossierId { get; set; }

        public string? LeasingCompanyCode { get; set; }

        public string? LeasingCompanyName { get; set; }

        public Guid? DossierInsureeId { get; set; }

        public string? DossierInsureeLastName { get; set; }

        public string? DossierInsureeFirstName { get; set; }

        public string? DossierInsureePrefixLastName { get; set; }

        public string? DossierInsureeStreetName { get; set; }

        public string? DossierInsureeHouseNumber { get; set; }

        public string? DossierInsureeHouseNumberAddition { get; set; }

        public string? DossierInsureeCity { get; set; }

        public string? DossierInsureePostalCode { get; set; }

        public string? DossierInsureeCountryCode { get; set; }

        public DateTime? DossierInsureeDateOfBirth { get; set; }

        public DateTime? CreatedDate { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime? LastModifiedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public byte[]? TimeStamp { get; set; }
    }
}