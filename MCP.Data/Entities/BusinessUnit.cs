namespace CED.Data.Entities
{
    public class BusinessUnit
    {
        public Guid BuId { get; set; }

        public byte[] BuTimeStamp { get; set; } = null!;

        public Guid BuLegalEntityId { get; set; }

        public Guid? BuCostCenterId { get; set; }

        public DateTime BuCreatedDate { get; set; }

        public string? BuCreatedBy { get; set; }

        public DateTime BuLastModifiedDate { get; set; }

        public string? BuLastModifiedBy { get; set; }

        public virtual OrganizationUnit Bu { get; set; } = null!;

        public virtual CostCenter? BuCostCenter { get; set; }

        public virtual LegalEntity BuLegalEntity { get; set; } = null!;

        public virtual ICollection<ClientInvoiceDeliveryMethod> ClientInvoiceDeliveryMethods { get; } =
            new List<ClientInvoiceDeliveryMethod>();

        public virtual ICollection<CreditorTemplate> CreditorTemplates { get; } = new List<CreditorTemplate>();

        public virtual ICollection<DebtorTemplate> DebtorTemplates { get; } = new List<DebtorTemplate>();

        public virtual ICollection<Department> Departments { get; } = new List<Department>();

        public virtual ICollection<SupplierInvoiceDeliveryMethod> SupplierInvoiceDeliveryMethods { get; } =
            new List<SupplierInvoiceDeliveryMethod>();
    }
}