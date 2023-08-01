namespace CED.Data.Entities
{
    public class RoadLocation
    {
        public Guid RdlId { get; set; }

        public long? RdlExternalId { get; set; }

        public string RdlDescription { get; set; } = null!;

        public bool RdlIsMainRoad { get; set; }

        public string? RdlRoadSectionId { get; set; }

        public int? RdlHectometerMarker { get; set; }

        public string? RdlRoadNumber { get; set; }

        public string? RdlRoadTypeId { get; set; }

        public string? RdlRoadSideId { get; set; }

        public string? RdlRoadDirectionId { get; set; }

        public string? RdlRoadAddition { get; set; }

        public double? RdlRoadX { get; set; }

        public double? RdlRoadY { get; set; }

        public double? RdlWorldGeodeticSystem84X { get; set; }

        public double? RdlWorldGeodeticSystem84Y { get; set; }

        public string? RdlRoadAuthorityCodeId { get; set; }

        public DateTime RdlCreatedDate { get; set; }

        public string? RdlCreatedBy { get; set; }

        public DateTime RdlLastModifiedDate { get; set; }

        public string? RdlLastModifiedBy { get; set; }
    }
}