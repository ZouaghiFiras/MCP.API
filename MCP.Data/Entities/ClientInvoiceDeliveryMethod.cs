namespace CED.Data.Entities
{
    public class ClientInvoiceDeliveryMethod
    {
        public Guid CdmId { get; set; }

        public byte[] CdmTimeStamp { get; set; } = null!;

        public Guid CdmLegalEntityId { get; set; }

        public Guid? CdmBusinessUnitId { get; set; }

        public Guid? CdmDepartmentId { get; set; }

        public string? CdmEmail { get; set; }

        public string? CdmBodyEmail { get; set; }

        public Guid CdmClientId { get; set; }

        public string CdmInvoiceDeliveryMethodId { get; set; } = null!;

        public Guid CdmDebtorId { get; set; }

        public DateTime CdmEffectiveDate { get; set; }

        public DateTime? CdmTerminationDate { get; set; }

        public DateTime CdmCreatedDate { get; set; }

        public string? CdmCreatedBy { get; set; }

        public DateTime CdmLastModifiedDate { get; set; }

        public string? CdmLastModifiedBy { get; set; }

        public virtual BusinessUnit? CdmBusinessUnit { get; set; }

        public virtual Client CdmClient { get; set; } = null!;

        public virtual Debtor CdmDebtor { get; set; } = null!;

        public virtual Department? CdmDepartment { get; set; }

        public virtual InvoiceDeliveryMethod CdmInvoiceDeliveryMethod { get; set; } = null!;

        public virtual LegalEntity CdmLegalEntity { get; set; } = null!;
    }
}