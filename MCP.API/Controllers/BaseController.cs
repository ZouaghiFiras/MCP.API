// Bring in the necessary namespaces for the classes and interfaces used in this code.
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace MCP.API.Controllers
{
    /// <summary>
    ///     This is the base controller.
    /// </summary>
    [Authorize]
    public class BaseController : ControllerBase
    {

    }
}