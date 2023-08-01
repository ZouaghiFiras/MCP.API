namespace CED.Data.Entities
{
    public class OrganizationUnitsWithCurrentStatusInnerSelect
    {
        public Guid OuId { get; set; }

        public byte[] OuTimeStamp { get; set; } = null!;

        public string OuCode { get; set; } = null!;

        public string? OuShortName { get; set; }

        public string OuLongName { get; set; } = null!;

        public string? OuLongName2 { get; set; }

        public string? OuLongName3 { get; set; }

        public string? OuPorCode { get; set; }

        public DateTime? OuStartDate { get; set; }

        public DateTime? OuEndDate { get; set; }

        public bool OuInactive { get; set; }

        public Guid? OuOrganizationTypeId { get; set; }

        public Guid? OuHierarchyTypeId { get; set; }

        public Guid? OuAddressId { get; set; }

        public Guid? OuPostOfficeBoxId { get; set; }

        public Guid? OuOrganizationGroupId { get; set; }

        public Guid? OuCollectionCodeId { get; set; }

        public string? OuWebsite { get; set; }

        public string? OuEmail { get; set; }

        public string? OuVatNumber { get; set; }

        public string? OuVatCountryCode { get; set; }

        public bool OuNoVatNumber { get; set; }

        public string? OuChamberOfCommerceNumber { get; set; }

        public DateTime OuCreatedDate { get; set; }

        public string? OuCreatedBy { get; set; }

        public DateTime OuLastModifiedDate { get; set; }

        public string? OuLastModifiedBy { get; set; }

        public string? OuPhone { get; set; }

        public string? OuFax { get; set; }

        public Guid? OuTenantId { get; set; }

        public string? OuSalesTaxCodeId { get; set; }

        public string? OuPurchaseTaxCodeId { get; set; }

        public bool OuIsTaxExempted { get; set; }

        public string? OuTaxExemptNumber { get; set; }

        public bool OuIsNotCompany { get; set; }

        public string? ValidationStatusId { get; set; }

        public string? Listvalues { get; set; }
    }
}