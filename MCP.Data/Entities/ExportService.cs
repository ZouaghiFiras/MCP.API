namespace CED.Data.Entities
{
    public class ExportService
    {
        public string? SkillCode { get; set; }

        public string? SkillNameNl { get; set; }

        public string? SkillNameEng { get; set; }

        public string? ServiceGroupCode { get; set; }

        public string? ServiceGroupNameNl { get; set; }

        public string? ServiceGroupNameEng { get; set; }

        public string ServiceCode { get; set; } = null!;

        public string? ServiceType { get; set; }

        public string? ServiceRelation { get; set; }

        public string? ServiceNl { get; set; }

        public string? ServiceBenl { get; set; }

        public string? ServiceBefr { get; set; }

        public string ServiceEng { get; set; } = null!;

        public double? RelationDivider { get; set; }

        public double? ChildunitPriceIndex { get; set; }

        public string Active { get; set; } = null!;
    }
}