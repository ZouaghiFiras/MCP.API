namespace CED.Data.Entities
{
    public class Dbaudit
    {
        public string? EventType { get; set; }

        public string? PostTime { get; set; }

        public string? HostName { get; set; }

        public string? ApplicationName { get; set; }

        public string? Spid { get; set; }

        public string? ServerName { get; set; }

        public string? LoginName { get; set; }

        public string? UserName { get; set; }

        public string? DatabaseName { get; set; }

        public string? SchemaName { get; set; }

        public string? ObjectName { get; set; }

        public string? ObjectType { get; set; }

        public string? CommandText { get; set; }
    }
}