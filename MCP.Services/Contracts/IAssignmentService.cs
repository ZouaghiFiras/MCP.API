using System.Collections.Generic;
using MCP.Data.Models;
using MCP.Services.DTO;

namespace MCP.Services.Contracts
{
    /// <summary>
    /// Interface defining the contract for a service that deals with assignments.
    /// </summary>
    public interface IAssignmentService
    {
        /// <summary>
        /// Returns all assignments in the specified culture code.
        /// </summary>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>A collection of Assignment objects.</returns>
        IEnumerable<Assignment> GetAll(string cultureCode);

        /// <summary>
        /// Returns a paged list of assignments that match the specified search criteria and culture code.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <param name="skip">The number of items to skip.</param>
        /// <param name="take">The number of items to take.</param>
        /// <returns>A PagingDto object containing the paged list of assignments.</returns>
        PagingDto GetPaginatedResults(SearchCriteria searchCriteria, string cultureCode, int skip, int take);
        /// <summary>
        ///     Get a list of assignments based on the provided search criteriavalues.
        /// </summary>
        /// <param name="searchCriteria">The search criteria.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>The Search Results containing the list of assignments.</returns>
        IEnumerable<Assignment> GetSearchResults(SearchCriteria searchCriteria, string cultureCode);
        /// <summary>
        /// Returns the details of the assignment with the specified assignment number in the specified culture code.
        /// </summary>
        /// <param name="assignmentNumber">The assignment number.</param>
        /// <param name="cultureCode">The culture code.</param>
        /// <returns>An AssignmentDetails object containing the details of the assignment.</returns>
        AssignmentDetails GetAssignmentDetailsByAssignmentNumber(string assignmentNumber, string cultureCode);
    }
}