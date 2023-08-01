namespace CED.Data.Entities
{
    public class VisitInformationLogHistory
    {
        public Guid VlhId { get; set; }

        public byte[] VlhTimeStamp { get; set; } = null!;

        public Guid VlhVisitInformationId { get; set; }

        public int VlhLineNumber { get; set; }

        public Guid? VlhRoleCodeId { get; set; }

        public Guid? VlhLogHistoryTypeId { get; set; }

        public string? VlhFreeText { get; set; }

        public DateTime VlhCreatedDate { get; set; }

        public string? VlhCreatedBy { get; set; }

        public DateTime VlhLastModifiedDate { get; set; }

        public string? VlhLastModifiedBy { get; set; }

        public virtual LogHistoryType? VlhLogHistoryType { get; set; }

        public virtual RoleCode? VlhRoleCode { get; set; }

        public virtual VisitInformation VlhVisitInformation { get; set; } = null!;
    }
}