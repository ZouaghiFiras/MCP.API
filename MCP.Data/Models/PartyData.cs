namespace MCP.Data.Models
{
    /// <summary>
    /// Represents party data associated with an assignment.
    /// </summary>
    public class PartyData
    {
        /// <summary>
        /// Gets or sets the type of party.
        /// </summary>
        public string PartyType { get; set; }

        /// <summary>
        /// Gets or sets the name of the party.
        /// </summary>
        public string PartyName { get; set; }

        /// <summary>
        /// Gets or sets the address of the party.
        /// </summary>
        public string PartyAddress { get; set; }
    }
}