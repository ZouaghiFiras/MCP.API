namespace CED.Data.Entities
{
    public class DraftApproval
    {
        public Guid DraId { get; set; }

        public byte[] DraTimeStamp { get; set; } = null!;

        public string DraUserName { get; set; } = null!;

        public string DraDraftName { get; set; } = null!;

        public Guid DraIdSelected { get; set; }

        public bool DraIsApproved { get; set; }

        public string? DraComment { get; set; }

        public DateTime DraCreatedDate { get; set; }

        public string? DraCreatedBy { get; set; }

        public DateTime DraLastModifiedDate { get; set; }

        public string? DraLastModifiedBy { get; set; }
    }
}