namespace CED.Data.Entities
{
    public class PurchaseReceipt
    {
        public Guid PrhId { get; set; }

        public byte[] PrhTimeStamp { get; set; } = null!;

        public string PrhReceiptNumber { get; set; } = null!;

        public DateTime PrhReceiptDate { get; set; }

        public bool PrhIsCredit { get; set; }

        public Guid PrhSupplierId { get; set; }

        public string? PrhShipmentNumber { get; set; }

        public DateTime? PrhShipmentDate { get; set; }

        public Guid PrhDepartmentId { get; set; }

        public bool PrhIsPrinted { get; set; }

        public bool PrhIsImported { get; set; }

        public string? PrhCultureCode { get; set; }

        public Guid? PrhEmployeeId { get; set; }

        public bool PrhIsIntercompany { get; set; }

        public DateTime PrhCreatedDate { get; set; }

        public string? PrhCreatedBy { get; set; }

        public DateTime PrhLastModifiedDate { get; set; }

        public string? PrhLastModifiedBy { get; set; }

        public virtual Department PrhDepartment { get; set; } = null!;

        public virtual Employee? PrhEmployee { get; set; }

        public virtual Supplier PrhSupplier { get; set; } = null!;

        public virtual ICollection<PurchaseReceiptLine> PurchaseReceiptLines { get; } = new List<PurchaseReceiptLine>();
    }
}