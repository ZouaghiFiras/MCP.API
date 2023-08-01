﻿namespace CED.Data.Entities
{
    public class WorkingOrderLineCorrectionAuthorizationsWithoutApprovalsView
    {
        public Guid Id { get; set; }

        public Guid WorkingOrderLineId { get; set; }

        public string? CreatedBy { get; set; }

        public DateTime CreatedDate { get; set; }

        public string? LastModifiedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
    }
}