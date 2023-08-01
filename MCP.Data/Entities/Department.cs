namespace CED.Data.Entities
{
    public class Department
    {
        public Guid DepId { get; set; }

        public byte[] DepTimeStamp { get; set; } = null!;

        public Guid DepBusinessUnitId { get; set; }

        public Guid? DepProductLineId { get; set; }

        public Guid? DepCostUnitId { get; set; }

        public Guid? DepRegionId { get; set; }

        public DateTime DepCreatedDate { get; set; }

        public string? DepCreatedBy { get; set; }

        public DateTime DepLastModifiedDate { get; set; }

        public string? DepLastModifiedBy { get; set; }

        public virtual ICollection<BookingDimension> BookingDimensions { get; } = new List<BookingDimension>();

        public virtual ICollection<ClaimReserf> ClaimReserves { get; } = new List<ClaimReserf>();

        public virtual ICollection<ClientInvoiceDeliveryMethod> ClientInvoiceDeliveryMethods { get; } =
            new List<ClientInvoiceDeliveryMethod>();

        public virtual ICollection<CreditorTemplate> CreditorTemplates { get; } = new List<CreditorTemplate>();

        public virtual ICollection<DebtorTemplate> DebtorTemplates { get; } = new List<DebtorTemplate>();

        public virtual ICollection<DefaultTemplate> DefaultTemplates { get; } = new List<DefaultTemplate>();

        public virtual OrganizationUnit Dep { get; set; } = null!;

        public virtual BusinessUnit DepBusinessUnit { get; set; } = null!;

        public virtual CostUnit? DepCostUnit { get; set; }

        public virtual ProductLine? DepProductLine { get; set; }

        public virtual Region? DepRegion { get; set; }

        public virtual ICollection<DepartmentOffice> DepartmentOffices { get; } = new List<DepartmentOffice>();

        public virtual ICollection<DocumentTypeDepartment> DocumentTypeDepartments { get; } =
            new List<DocumentTypeDepartment>();

        public virtual ICollection<DossierAssignment> DossierAssignments { get; } = new List<DossierAssignment>();

        public virtual ICollection<Dossier> Dossiers { get; } = new List<Dossier>();

        public virtual ICollection<Employee> Employees { get; } = new List<Employee>();

        public virtual ICollection<HandlingCountry> HandlingCountries { get; } = new List<HandlingCountry>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<ProductDepartment> ProductDepartments { get; } = new List<ProductDepartment>();

        public virtual ICollection<Product> Products { get; } = new List<Product>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<PurchaseReceipt> PurchaseReceipts { get; } = new List<PurchaseReceipt>();

        public virtual ICollection<SubContract> SubContracts { get; } = new List<SubContract>();

        public virtual ICollection<SupplierInvoiceDeliveryMethod> SupplierInvoiceDeliveryMethods { get; } =
            new List<SupplierInvoiceDeliveryMethod>();

        public virtual ICollection<Team> Teams { get; } = new List<Team>();
    }
}