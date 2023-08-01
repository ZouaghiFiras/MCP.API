// Bring in the necessary namespaces for the classes and interfaces used in this code
using System.Collections.Generic;
using MCP.Data.Models;

namespace MCP.Services.DTO
{
    /// <summary>
    /// Data Transfer Object (DTO) representing a page of assignments.
    /// </summary>
    public class PagingDto
    {
        /// <summary>
        /// Gets or sets the collection of assignments on the page.
        /// </summary>
        public IEnumerable<Assignment> Assignments { get; set; }

        /// <summary>
        /// Gets or sets the total number of assignments.
        /// </summary>
        public int? Total { get; set; }
    }
}
