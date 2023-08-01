// Bring in the necessary namespaces for the classes and interfaces used in this code
using System.Diagnostics.CodeAnalysis;
using MCP.Data;
using MCP.Data.Helpers;
using MCP.Data.Interfaces;
using MCP.Data.Repositories;
using MCP.Services.Components;
using MCP.Services.Contracts;
using Microsoft.Extensions.DependencyInjection;

namespace MCP.Services.DependencyInjection
{
    /// <summary>
    /// Static class containing extension method to register components and services in the dependency injection container.
    /// </summary>
    public static class ComponentsServiceCollectionExtensions
    {
        /// <summary>
        /// Registers various components and services in the dependency injection container.
        /// </summary>
        /// <param name="services">The collection of services to add to.</param>
        /// <returns>The same collection of services with the added components and services.</returns>
        [SuppressMessage("ReSharper.DPA", "DPA0000: DPA issues")]
        public static IServiceCollection RegisterComponents(this IServiceCollection services)
        {
            // Add scoped dependencies for the assignment service and repository
            services.AddScoped<IAssignmentService, AssignmentService>();
            services.AddScoped<IAssignmentRepository, AssignmentRepository>();

            services.AddScoped<IFileService, FileService>();

            // Add scoped dependencies for the contact service
            services.AddScoped<IContactService, ContactService>();

            // Add scoped dependencies for the cache provider and database provider
            services.AddScoped<ICacheProvider, CacheProvider>();
            services.AddScoped<IDataBaseProvider, DataBaseProvider>();

            // Add scoped dependencies for the SharePoint service and repository
            services.AddScoped<ISharePointApiService, SharePointApiService>();
            services.AddScoped<ISharePointApiRepository, SharePointApiRepository>();

            // Create a new instance of the cache provider using a new instance of the database provider
            // constructed with a SqliteDataContext object
            var cacheProvider = new CacheProvider(new DataBaseProvider(new DataContext()));

            // Call the OnInit method of the cache provider to set up any necessary configuration
            cacheProvider.onInit();

            // Return the collection of services with the added components and services
            return services;
        }
    }
}
