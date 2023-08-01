namespace CED.Data.Entities
{
    public class Document
    {
        public Guid DocId { get; set; }

        public byte[] DocTimeStamp { get; set; } = null!;

        public string? DocDocumentNumber { get; set; }

        public DateTime DocDocumentDate { get; set; }

        public Guid DocDocumentTypeId { get; set; }

        public string? DocDescription { get; set; }

        public bool DocHasSignature { get; set; }

        public DateTime? DocSignatureDate { get; set; }

        public string? DocMimeType { get; set; }

        public string? DocOrigin { get; set; }

        public DateTime DocCreatedDate { get; set; }

        public string? DocCreatedBy { get; set; }

        public DateTime DocLastModifiedDate { get; set; }

        public string? DocLastModifiedBy { get; set; }

        public virtual ICollection<BankAccountAttachment> BankAccountAttachments { get; } =
            new List<BankAccountAttachment>();

        public virtual ICollection<BankStatementAttachment> BankStatementAttachments { get; } =
            new List<BankStatementAttachment>();

        public virtual ICollection<BankStatementLineAttachment> BankStatementLineAttachments { get; } =
            new List<BankStatementLineAttachment>();

        public virtual DocumentType DocDocumentType { get; set; } = null!;

        public virtual ICollection<DocumentAttribute> DocumentAttributes { get; } = new List<DocumentAttribute>();

        public virtual ICollection<DocumentPage> DocumentPages { get; } = new List<DocumentPage>();

        public virtual ICollection<DossierAttachment> DossierAttachments { get; } = new List<DossierAttachment>();

        public virtual ICollection<OrganizationAccountAttachment> OrganizationAccountAttachments { get; } =
            new List<OrganizationAccountAttachment>();

        public virtual ICollection<Post> Posts { get; } = new List<Post>();

        public virtual ICollection<PurchaseBacklogAttachment> PurchaseBacklogAttachments { get; } =
            new List<PurchaseBacklogAttachment>();

        public virtual ICollection<PurchaseInvoiceAttachment> PurchaseInvoiceAttachments { get; } =
            new List<PurchaseInvoiceAttachment>();

        public virtual ICollection<PurchaseOrder> PurchaseOrders { get; } = new List<PurchaseOrder>();

        public virtual ICollection<SalesCollectionAttachment> SalesCollectionAttachments { get; } =
            new List<SalesCollectionAttachment>();

        public virtual ICollection<SalesInvoiceAttachment> SalesInvoiceAttachments { get; } =
            new List<SalesInvoiceAttachment>();

        public virtual ICollection<SalesOrderAttachment> SalesOrderAttachments { get; } =
            new List<SalesOrderAttachment>();

        public virtual ICollection<WorkingOrderLineAttachment> WorkingOrderLineAttachments { get; } =
            new List<WorkingOrderLineAttachment>();
    }
}