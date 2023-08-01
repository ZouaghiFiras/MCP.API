namespace MCP.Data.Models
{
    public class CreateApiClientTokenRequest
    {
        public string? Email { get; set; }
        public string? Secret { get; set; }
    }
}