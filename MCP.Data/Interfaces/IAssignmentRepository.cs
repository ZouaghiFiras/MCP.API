// Bring in the necessary namespaces for the classes and interfaces used in this code.
using MCP.Data.Models;

namespace MCP.Data.Interfaces
{
    /// <summary>
    /// Interface defining the contract for a repository that handles assignments.
    /// </summary>
    public interface IAssignmentRepository
    {
        /// <summary>
        /// Retrieves all assignments in the specified culture code.
        /// </summary>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>A collection of assignments.</returns>
        IEnumerable<Assignment> GetAllAssignments(string cultureCode);

        /// <summary>
        /// Searches for assignments based on the specified search criteria and culture code.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>A collection of matching assignments.</returns>
        IEnumerable<Assignment> Search(SearchCriteria searchCriteria, string cultureCode);

        /// <summary>
        /// Retrieves the details of the assignment with the specified assignment number and culture code.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>The assignment details.</returns>
        AssignmentDetails GetAssignmentDetails(string assignmentNumber, string cultureCode);
    }
}
