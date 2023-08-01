namespace CED.Data.Entities
{
    public class TemplateType
    {
        public Guid TptId { get; set; }

        public byte[] TptTimeStamp { get; set; } = null!;

        public string? TptTemplateTypeName { get; set; }

        public DateTime TptCreatedDate { get; set; }

        public string? TptCreatedBy { get; set; }

        public DateTime TptLastModifiedDate { get; set; }

        public string? TptLastModifiedBy { get; set; }

        public string? TptTemplateTypeCode { get; set; }

        public virtual ICollection<Template> Templates { get; } = new List<Template>();
    }
}