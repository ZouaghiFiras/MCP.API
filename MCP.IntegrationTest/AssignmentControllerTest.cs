using Microsoft.AspNetCore.Mvc;
using Moq;
using MCP.Data.Models;
using MCP.Services.Contracts;
using MCP.Services.DTO;

namespace MCP.API.Controllers.Tests
{
    public class AssignmentControllerTests
    {
        private readonly Mock<IAssignmentService> _assignmentServiceMock;
        private readonly AssignmentController _controller;

        public AssignmentControllerTests()
        {
            _assignmentServiceMock = new Mock<IAssignmentService>();
            _controller = new AssignmentController(_assignmentServiceMock.Object);
        }

        [Fact]
        public void GetAssignments_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var cultureCode = "en-US";
            var assignments = new List<Assignment> { new Assignment(), new Assignment() };

            _assignmentServiceMock.Setup(mock => mock.GetAll(cultureCode))
                .Returns(assignments);

            // Act
            var result = _controller.GetAssignments(cultureCode);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(assignments, okResult.Value);
        }

        [Fact]
        public void GetAssignments_MissingCultureCode_ReturnsBadRequestResult()
        {
            // Arrange

            // Act
            var result = _controller.GetAssignments(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetAssignments_ExceptionThrown_ReturnsInternalServerErrorResult()
        {
            // Arrange
            var cultureCode = "en-US";

            _assignmentServiceMock.Setup(mock => mock.GetAll(cultureCode))
                .Throws(new Exception());

            // Act
            var result = _controller.GetAssignments(cultureCode);

            // Assert
            Assert.IsType<StatusCodeResult>(result);
            var statusCodeResult = (StatusCodeResult)result;
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public void GetPaginated_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            var cultureCode = "en-US";
            var skip = 0;
            var take = 10;
            var result = new PagingDto();

            _assignmentServiceMock.Setup(mock => mock.GetPaginatedResults(searchCriteria, cultureCode, skip, take))
                .Returns(result);

            // Act
            var actionResult = _controller.GetPaginated(searchCriteria, cultureCode, skip, take);

            // Assert
            Assert.IsType<OkObjectResult>(actionResult);
            var okResult = (OkObjectResult)actionResult;
            Assert.Equal(result, okResult.Value);
        }

        [Fact]
        public void GetPaginated_MissingSearchCriteria_ReturnsBadRequestResult()
        {
            // Arrange
            var cultureCode = "en-US";
            var skip = 0;
            var take = 10;

            // Act
            var result = _controller.GetPaginated(null, cultureCode, skip, take);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetPaginated_MissingCultureCode_ReturnsBadRequestResult()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            var skip = 0;
            var take = 10;

            // Act
            var result = _controller.GetPaginated(searchCriteria, null, skip, take);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetPaginated_MissingSkip_ReturnsBadRequestResult()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            var cultureCode = "en-US";
            var take = 10;

            // Act
            var result = _controller.GetPaginated(searchCriteria, cultureCode, 10, take);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetPaginated_MissingTake_ReturnsBadRequestResult()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            var cultureCode = "en-US";
            var skip = 0;

            // Act
            var result = _controller.GetPaginated(searchCriteria, cultureCode, skip, 10);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetPaginated_ExceptionThrown_ReturnsInternalServerErrorResult()
        {
            // Arrange
            var searchCriteria = new SearchCriteria();
            var cultureCode = "en-US";
            var skip = 0;
            var take = 10;

            _assignmentServiceMock.Setup(mock => mock.GetPaginatedResults(searchCriteria, cultureCode, skip, take))
                .Throws(new Exception());

            // Act
            var result = _controller.GetPaginated(searchCriteria, cultureCode, skip, take);

            // Assert
            Assert.IsType<StatusCodeResult>(result);
            var statusCodeResult = (StatusCodeResult)result;
            Assert.Equal(500, statusCodeResult.StatusCode);
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var cultureCode = "en-US";
            var assignmentDetails = new AssignmentDetails();

            _assignmentServiceMock.Setup(mock => mock.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode))
                .Returns(assignmentDetails);

            // Act
            var result = _controller.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(assignmentDetails, result.Value);
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange
            var cultureCode = "en-US";

            // Act
            var result = _controller.GetAssignmentDetailsByAssignmentNumber(null, cultureCode);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_MissingCultureCode_ReturnsBadRequestResult()
        {
            // Arrange
            var assignmentNumber = "123";

            // Act
            var result = _controller.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_ArgumentExceptionThrown_ReturnsBadRequestResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var cultureCode = "en-US";

            _assignmentServiceMock.Setup(mock => mock.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode))
                .Throws(new ArgumentException("Invalid assignment number"));

            // Act
            var result = _controller.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode);

            // Assert
            Assert.IsType<BadRequestObjectResult>(result);
            Assert.Equal("Invalid assignment number", result.Result.ToString());
        }

        [Fact]
        public void GetAssignmentDetailsByAssignmentNumber_ExceptionThrown_ReturnsInternalServerErrorResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var cultureCode = "en-US";

            _assignmentServiceMock.Setup(mock => mock.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode))
                .Throws(new Exception());

            // Act
            var result = _controller.GetAssignmentDetailsByAssignmentNumber(assignmentNumber, cultureCode);

            // Assert
            Assert.IsType<StatusCodeResult>(result);
        }
    }
}
