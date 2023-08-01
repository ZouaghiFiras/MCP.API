namespace CED.Data.Entities
{
    public class DossierAssignmentVisitInformation
    {
        public Guid DavId { get; set; }

        public byte[] DavTimeStamp { get; set; } = null!;

        public Guid DavDossierAssignmentId { get; set; }

        public Guid DavVisitInformationId { get; set; }

        public DateTime DavCreatedDate { get; set; }

        public string? DavCreatedBy { get; set; }

        public DateTime DavLastModifiedDate { get; set; }

        public string? DavLastModifiedBy { get; set; }

        public virtual DossierAssignment DavDossierAssignment { get; set; } = null!;

        public virtual VisitInformation DavVisitInformation { get; set; } = null!;
    }
}