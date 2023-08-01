// Bring in the necessary namespaces for the classes and interfaces used in this code

using CED.Data.Entities;
using MCP.Data;
using MCP.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace CED.UnitTest.Helpers
{
    /// <summary>
    ///     A helper class for creating a data context for unit tests.
    /// </summary>
    public static class ContextHelper
    {
        // The number of assignments to create for the data context
        public static int AssignmentsCount = 5;

        /// <summary>
        ///     Creates a new instance of the data context for use in unit tests.
        /// </summary>
        /// <returns>A new data context instance.</returns>
        public static DataContext CreateContext()
        {
            // Configure the in-memory database for the data context
            var options = new DbContextOptionsBuilder<DataContext>()
                .UseInMemoryDatabase("TestDataContext")
                .EnableSensitiveDataLogging()
                .Options;

            // Create a new data context instance with the configured options
            var dataContext = new DataContext(options);

            // Add some sample assignments to the data context
            AddAssignments(dataContext);

            // Save changes to the data context
            dataContext.SaveChanges();

            // Return the data context instance
            return dataContext;
        }

        /// <summary>
        ///     Adds some sample assignments to the specified data context.
        /// </summary>
        /// <param name="dataContext">The data context to add the assignments to.</param>
        private static void AddAssignments(DataContext dataContext)
        {
            // Create a list of assignments to add to the data context
            var assignments = new List<Assignment>();

            // Add the specified number of assignments to the list
            for (var i = 0; i < AssignmentsCount; i++)
            {
                assignments.Add(new Assignment
                {
                    AssignmentNumber = $"a{i}",
                    CaseNumber = $"Assignment{i}",
                    InvolvedParty = $"ct{i}"
                });
            }

            // Add the list of assignments to the data context
            dataContext.DossierAssignments.AddRange((IEnumerable<DossierAssignment>)assignments);
        }
    }
}