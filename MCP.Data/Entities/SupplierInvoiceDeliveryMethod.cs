namespace CED.Data.Entities
{
    public class SupplierInvoiceDeliveryMethod
    {
        public Guid SdmId { get; set; }

        public byte[] SdmTimeStamp { get; set; } = null!;

        public Guid SdmLegalEntityId { get; set; }

        public Guid SdmSupplierId { get; set; }

        public string SdmInvoiceDeliveryMethodId { get; set; } = null!;

        public DateTime SdmEffectiveDate { get; set; }

        public DateTime? SdmTerminationDate { get; set; }

        public DateTime SdmCreatedDate { get; set; }

        public string? SdmCreatedBy { get; set; }

        public DateTime SdmLastModifiedDate { get; set; }

        public string? SdmLastModifiedBy { get; set; }

        public Guid? SdmBusinessUnitId { get; set; }

        public Guid? SdmDepartmentId { get; set; }

        public string? SdmEmail { get; set; }

        public string? SdmBodyEmail { get; set; }

        public virtual BusinessUnit? SdmBusinessUnit { get; set; }

        public virtual Department? SdmDepartment { get; set; }

        public virtual InvoiceDeliveryMethod SdmInvoiceDeliveryMethod { get; set; } = null!;

        public virtual LegalEntity SdmLegalEntity { get; set; } = null!;

        public virtual Supplier SdmSupplier { get; set; } = null!;
    }
}