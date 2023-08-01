namespace CED.Data.Entities
{
    public class Post
    {
        public Guid PostId { get; set; }

        public byte[] PostTimeStamp { get; set; } = null!;

        public string PostPostNumber { get; set; } = null!;

        public DateTime PostPostDate { get; set; }

        public string? PostPostReference { get; set; }

        public string? PostEmailFrom { get; set; }

        public string? PostEmailTo { get; set; }

        public string? PostEmailCc { get; set; }

        public string? PostEmailSubject { get; set; }

        public string? PostEmailMessage { get; set; }

        public DateTime? PostSendDate { get; set; }

        public DateTime? PostReceiveDate { get; set; }

        public string? PostComments { get; set; }

        public Guid? PostCommunicationTypeId { get; set; }

        public Guid? PostPostHandlingPriorityId { get; set; }

        public DateTime? PostIndexingDate { get; set; }

        public string? PostIndexingArchiveId { get; set; }

        public Guid? PostLegalEntityId { get; set; }

        public Guid? PostDepartmentId { get; set; }

        public Guid? PostEmployeeId { get; set; }

        public Guid? PostDossierId { get; set; }

        public Guid? PostDossierAssignmentId { get; set; }

        public Guid? PostDossierPartyId { get; set; }

        public Guid? PostOriginalDocumentId { get; set; }

        public bool PostIsBodilyInjury { get; set; }

        public DateTime PostCreatedDate { get; set; }

        public string? PostCreatedBy { get; set; }

        public DateTime PostLastModifiedDate { get; set; }

        public string? PostLastModifiedBy { get; set; }

        public bool PostInactive { get; set; }

        public virtual ICollection<PostAttachment> PostAttachments { get; } = new List<PostAttachment>();

        public virtual CommunicationType? PostCommunicationType { get; set; }

        public virtual PostCurrentStatus? PostCurrentStatus { get; set; }

        public virtual Department? PostDepartment { get; set; }

        public virtual Dossier? PostDossier { get; set; }

        public virtual DossierAssignment? PostDossierAssignment { get; set; }

        public virtual DossierParty? PostDossierParty { get; set; }

        public virtual Employee? PostEmployee { get; set; }

        public virtual LegalEntity? PostLegalEntity { get; set; }

        public virtual Document? PostOriginalDocument { get; set; }

        public virtual PostHandlingPriority? PostPostHandlingPriority { get; set; }

        public virtual ICollection<PostStatusHistory> PostStatusHistories { get; } = new List<PostStatusHistory>();

        public virtual ICollection<PostTag> PostTags { get; } = new List<PostTag>();
    }
}