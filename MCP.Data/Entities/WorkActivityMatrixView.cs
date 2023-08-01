namespace CED.Data.Entities
{
    public class WorkActivityMatrixView
    {
        public Guid Id { get; set; }

        public string ActivityCode { get; set; } = null!;

        public string Description { get; set; } = null!;

        public string? Activity { get; set; }

        public string? Task { get; set; }

        public string? Video { get; set; }

        public string? Telefonisch { get; set; }

        public string? Fysiek { get; set; }

        public string? Standaard { get; set; }

        public string? Verkort { get; set; }

        public string? Uitgebreid { get; set; }
    }
}