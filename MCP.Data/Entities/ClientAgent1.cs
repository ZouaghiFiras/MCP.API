﻿namespace CED.Data.Entities
{
    public class ClientAgent1
    {
        public Guid ClaId { get; set; }

        public byte[] ClaTimeStamp { get; set; } = null!;

        public Guid ClaClientId { get; set; }

        public Guid ClaAgentId { get; set; }

        public string? ClaAgentCode { get; set; }

        public string? ClaAgentName { get; set; }

        public bool ClaInactive { get; set; }

        public DateTime ClaCreatedDate { get; set; }

        public string? ClaCreatedBy { get; set; }

        public DateTime ClaLastModifiedDate { get; set; }

        public string? ClaLastModifiedBy { get; set; }
    }
}