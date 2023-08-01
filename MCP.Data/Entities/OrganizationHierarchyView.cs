namespace CED.Data.Entities
{
    public class OrganizationHierarchyView
    {
        public int? HierarchyLevel { get; set; }

        public string OgCode { get; set; } = null!;

        public string? NaamKort { get; set; }

        public string NaamCpl { get; set; } = null!;

        public string? TypeTpVerzOfVolmacht { get; set; }

        public string? ParentBovenliggendeType { get; set; }

        public string? NiveauPlekInStructuur { get; set; }

        public DateTime? Startdatum { get; set; }

        public DateTime? Einddatum { get; set; }

        public string Actief { get; set; } = null!;

        public string? ChildOgCode { get; set; }

        public string? ChildNaamKort { get; set; }

        public string? ChildNaamCpl { get; set; }

        public string? ChildTypeTpVerzOfVolmacht { get; set; }

        public string? ChildParentBovenliggendeType { get; set; }

        public string? ChildNiveauPlekInStructuur { get; set; }

        public DateTime? ChildStartdatum { get; set; }

        public DateTime? ChildEinddatum { get; set; }

        public string? ChildActief { get; set; }

        public string? OrderPath { get; set; }
    }
}