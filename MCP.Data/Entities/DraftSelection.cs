namespace CED.Data.Entities
{
    public class DraftSelection
    {
        public Guid DrsId { get; set; }

        public byte[] DrsTimeStamp { get; set; } = null!;

        public string DrsUserName { get; set; } = null!;

        public string DrsDraftName { get; set; } = null!;

        public Guid DrsIdSelected { get; set; }

        public DateTime DrsCreatedDate { get; set; }

        public string? DrsCreatedBy { get; set; }

        public DateTime DrsLastModifiedDate { get; set; }

        public string? DrsLastModifiedBy { get; set; }
    }
}