
using MCP.API.Controllers;
using MCP.Data.Models;
using MCP.Services.Contracts;
using MCP.Services.DTO;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MCP.API.Tests.Controllers
{
    public class AssignmentControllerTests
    {
        private readonly AssignmentController _controller;
        private readonly Mock<IAssignmentService> _assignmentServiceMock;

        public AssignmentControllerTests()
        {
            _assignmentServiceMock = new Mock<IAssignmentService>();
            _controller = new AssignmentController(_assignmentServiceMock.Object);
        }

        [Fact]
        public void GetAssignments_WithValidCultureCode_ReturnsOkResult()
        {
            // Arrange
            string cultureCode = "en-US";
            var assignments = new List<Assignment>();

            _assignmentServiceMock.Setup(service => service.GetAll(cultureCode)).Returns(assignments);

            // Act
            var result = _controller.GetAssignments(cultureCode);

            // Assert
            Assert.IsType<OkObjectResult>(result);
        }

        [Fact]
        public void GetAssignments_WithInvalidCultureCode_ReturnsBadRequest()
        {
            // Arrange
            string cultureCode = null;

            // Act
            var result = _controller.GetAssignments(cultureCode);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetPaginated_WithValidParameters_ReturnsOkResult()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            string cultureCode = "en-US";
            int skip = 0;
            int take = 10;

            // TODO: Replace PaginatedResult<T> with an appropriate data structure or modify it based on your requirements.
            var result = new PagingDto();

            _assignmentServiceMock.Setup(service => service.GetPaginatedResults(searchCriteria, cultureCode, skip, take)).Returns(result);

            // Act
            var actionResult = _controller.GetPaginated(searchCriteria, cultureCode, skip, take);
            var okResult = Assert.IsType<OkObjectResult>(actionResult);
            var returnValue = Assert.IsAssignableFrom<PagingDto>(okResult.Value);

            // Assert
            Assert.Equal(result, returnValue);
        }

        [Fact]
        public void GetPaginated_WithInvalidParameters_ReturnsBadRequest()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            string cultureCode = null;
            int skip = 0;
            int take = 10;

            // Act
            var result = _controller.GetPaginated(searchCriteria, cultureCode, skip, take);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_WithValidParameters_ReturnsOkResult()
        {
            // Arrange
            string assignmentNumber = "123";
            string cultureCode = "en-US";
            var assignmentDetails = new AssignmentDetails();

            _assignmentServiceMock.Setup(service => service.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode)).Returns(assignmentDetails);

            // Act
            var actionResult = _controller.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode);
            var okResult = Assert.IsType<OkObjectResult>(actionResult);
            var returnValue = Assert.IsAssignableFrom<AssignmentDetails>(okResult.Value);

            // Assert
            Assert.Equal(assignmentDetails, returnValue);
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_WithInvalidParameters_ReturnsBadRequest()
        {
            // Arrange
            string assignmentNumber = null;
            string cultureCode = null;

            // Act
            var result = _controller.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
        }
    }
}
