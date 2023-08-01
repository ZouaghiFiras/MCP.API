using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using MCP.Data.Models;
using MCP.Services.Contracts;


namespace MCP.API.Controllers.Tests
{
    public class SharePointApiControllerTests
    {
        private readonly Mock<ISharePointApiService> _sharePointApiServiceMock;
        private readonly SharePointApiController _controller;

        public SharePointApiControllerTests()
        {
            _sharePointApiServiceMock = new Mock<ISharePointApiService>();
            _controller = new SharePointApiController(_sharePointApiServiceMock.Object);
        }

        [Fact]
        public async Task GetFiles_ValidRequest_ReturnsOkResultWithFiles()
        {
            // Arrange
            var assignmentNumber = "123";
            var fileDocuments = new List<Document> { new Document(), new Document() };

            _sharePointApiServiceMock.Setup(mock => mock.GetFilesAsync(assignmentNumber))
                .ReturnsAsync(fileDocuments);

            // Act
            var result = await _controller.GetFiles(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result;
            Assert.Equal(fileDocuments, okResult.Value);
        }

        [Fact]
        public async Task GetFiles_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange

            // Act
            var result = await _controller.GetFiles(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetFilesSrc_ValidRequest_ReturnsOkResultWithFileSrc()
        {
            // Arrange
            var assignmentNumber = "123";
            var filesSrc = new List<string> { "src1", "src2" };

            _sharePointApiServiceMock.Setup(mock => mock.GetFilesSrcAsync(assignmentNumber))
                .ReturnsAsync(filesSrc);

            // Act
            var result = await _controller.GetFilesSrc(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result;
            Assert.Equal(filesSrc, okResult.Value);
        }

        [Fact]
        public async Task GetFilesSrc_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange

            // Act
            var result = await _controller.GetFilesSrc(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetFileSrc_ValidRequest_ReturnsOkResultWithFileSrc()
        {
            // Arrange
            var assignmentNumber = "123";
            var fileName = "test.txt";
            var fileSrc = "src";

            _sharePointApiServiceMock.Setup(mock => mock.GetFileSrcAsync(fileName))
                .ReturnsAsync(fileSrc);

            // Act
            var result = await _controller.GetFileSrc(fileName);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = result;
            Assert.Equal(fileSrc, okResult.Value);
        }

        [Fact]
        public async Task GetFileSrc_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange
            var fileName = "test.txt";

            // Act
            var result = await _controller.GetFileSrc(fileName);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetFileSrc_MissingFileName_ReturnsBadRequestResult()
        {
            // Arrange
            var assignmentNumber = "123";

            // Act
            var result = await _controller.GetFileSrc(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

 
        [Fact]
        public async Task GetDocumentTypes_ValidRequest_ReturnsOkResultWithDocumentTypes()
        {
            // Arrange
            var documentTypes = new List<string> { "type1", "type2" };

            _sharePointApiServiceMock.Setup(mock => mock.GetDocumentTypes())
                .ReturnsAsync(documentTypes);

            // Act
            var result = await _controller.GetDocumentTypes();

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(documentTypes, okResult.Value);
        }

        [Fact]
        public async Task GetDocumentTypes_ExceptionThrown_ReturnsInternalServerErrorResult()
        {
            // Arrange
            _sharePointApiServiceMock.Setup(mock => mock.GetDocumentTypes())
                .Throws(new Exception());

            // Act
            var result = await _controller.GetDocumentTypes();

            // Assert
            Assert.IsType<StatusCodeResult>(result);
            var statusCodeResult = (StatusCodeResult)result;
            Assert.Equal(StatusCodes.Status500InternalServerError, statusCodeResult.StatusCode);
        }
    }
}
