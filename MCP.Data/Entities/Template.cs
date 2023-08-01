namespace CED.Data.Entities
{
    public class Template
    {
        public Guid TepId { get; set; }

        public byte[] TepTimeStamp { get; set; } = null!;

        public string? TepTemplateName { get; set; }

        public Guid TepTemplateTypeId { get; set; }

        public DateTime TepCreatedDate { get; set; }

        public string? TepCreatedBy { get; set; }

        public DateTime TepLastModifiedDate { get; set; }

        public string? TepLastModifiedBy { get; set; }

        public virtual ICollection<ClientTemplate> ClientTemplates { get; } = new List<ClientTemplate>();

        public virtual ICollection<CreditorTemplate> CreditorTemplates { get; } = new List<CreditorTemplate>();

        public virtual ICollection<DebtorTemplate> DebtorTemplates { get; } = new List<DebtorTemplate>();

        public virtual ICollection<DefaultTemplate> DefaultTemplates { get; } = new List<DefaultTemplate>();

        public virtual TemplateType TepTemplateType { get; set; } = null!;
    }
}