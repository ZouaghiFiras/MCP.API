﻿namespace CED.Data.Entities
{
    public class PostOfficeBox1
    {
        public Guid PobId { get; set; }

        public byte[] PobTimeStamp { get; set; } = null!;

        public string? PobLocalizedName { get; set; }

        public string? PobBoxNo { get; set; }

        public string? PobPostalCode { get; set; }

        public string? PobCity { get; set; }

        public string? PobProvince { get; set; }

        public string? PobCountryCode { get; set; }

        public DateTime PobCreatedDate { get; set; }

        public string? PobCreatedBy { get; set; }

        public DateTime PobLastModifiedDate { get; set; }

        public string? PobLastModifiedBy { get; set; }
    }
}