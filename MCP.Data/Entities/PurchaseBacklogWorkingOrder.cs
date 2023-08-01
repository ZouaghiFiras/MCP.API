﻿namespace CED.Data.Entities
{
    public class PurchaseBacklogWorkingOrder
    {
        public Guid PbwoId { get; set; }

        public byte[] PbwoTimeStamp { get; set; } = null!;

        public Guid PbwoPurchaseBacklogId { get; set; }

        public Guid PbwoWorkingOrderId { get; set; }

        public bool PbwoInactive { get; set; }

        public DateTime PbwoCreatedDate { get; set; }

        public string? PbwoCreatedBy { get; set; }

        public DateTime PbwoLastModifiedDate { get; set; }

        public string? PbwoLastModifiedBy { get; set; }

        public virtual PurchaseBacklog PbwoPurchaseBacklog { get; set; } = null!;

        public virtual WorkingOrder PbwoWorkingOrder { get; set; } = null!;
    }
}