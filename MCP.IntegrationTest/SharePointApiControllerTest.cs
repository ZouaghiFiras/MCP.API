
using MCP.Data.Models;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MCP.API.Controllers.Tests
{
    public class SharePointApiControllerTests
    {
        private readonly SharePointApiController _controller;
        private readonly Mock<ISharePointApiService> _sharePointApiServiceMock;

        public SharePointApiControllerTests()
        {
            _sharePointApiServiceMock = new Mock<ISharePointApiService>();
            _controller = new SharePointApiController(_sharePointApiServiceMock.Object);
        }

        [Fact]
        public async Task GetFiles_ValidRequest_ReturnsOkResultWithFiles()
        {
            // Arrange
            var assignmentNumber = "A123";
            var files = new List<Document> { /* Add the required files for testing */ };
            _sharePointApiServiceMock.Setup(mock => mock.GetFilesAsync(assignmentNumber)).ReturnsAsync(files);

            // Act
            var result = await _controller.GetFiles(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(files, (result).Value);
        }

        [Fact]
        public async Task GetFiles_InvalidRequest_ReturnsInternalServerError()
        {
            // Arrange
            var assignmentNumber = "A123";
            _sharePointApiServiceMock.Setup(mock => mock.GetFilesAsync(assignmentNumber)).ThrowsAsync(new Exception());

            // Act
            var result = await _controller.GetFiles(assignmentNumber);

            // Assert
            Assert.IsType<StatusCodeResult>(result);
        }

        [Fact]
        public async Task GetFilesSrc_ValidRequest_ReturnsOkResultWithFileSrc()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileSrc = new List<string> { /* Add the required file source URLs for testing */ };
            _sharePointApiServiceMock.Setup(mock => mock.GetFilesSrcAsync(assignmentNumber)).ReturnsAsync(fileSrc);

            // Act
            var result = await _controller.GetFilesSrc(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(fileSrc, (result).Value);
        }

        [Fact]
        public async Task GetFilesSrc_InvalidRequest_ReturnsInternalServerError()
        {
            // Arrange
            var assignmentNumber = "A123";
            _sharePointApiServiceMock.Setup(mock => mock.GetFilesSrcAsync(assignmentNumber)).ThrowsAsync(new Exception());

            // Act
            var result = await _controller.GetFilesSrc(assignmentNumber);

            // Assert
            Assert.IsType<StatusCodeResult>(result);
        }

        [Fact]
        public async Task GetFileSrc_ValidRequest_ReturnsOkResultWithFileSrc()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileName = "file.txt";
            var fileSrc = "http://example.com/file.txt";
            _sharePointApiServiceMock.Setup(mock => mock.GetFileSrcAsync(fileName)).ReturnsAsync(fileSrc);

            // Act
            var result = await _controller.GetFileSrc(fileName);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(fileSrc, (result).Value);
        }

        [Fact]
        public async Task GetFileSrc_InvalidRequest_ReturnsInternalServerError()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileName = "file.txt";
            _sharePointApiServiceMock.Setup(mock => mock.GetFileSrcAsync(fileName)).ThrowsAsync(new Exception());

            // Act
            var result = await _controller.GetFileSrc(fileName);

            // Assert
            Assert.IsType<StatusCodeResult>(result);
        }

 

        [Fact]
        public async Task GetDocumentTypes_ValidRequest_ReturnsOkResultWithDocumentTypes()
        {
            // Arrange
            var documentTypes = new List<string> { /* Add the required document types for testing */ };
            _sharePointApiServiceMock.Setup(mock => mock.GetDocumentTypes()).ReturnsAsync(documentTypes);

            // Act
            var result = await _controller.GetDocumentTypes();

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(documentTypes, ((OkObjectResult)result).Value);
        }

        [Fact]
        public async Task GetDocumentTypes_InvalidRequest_ReturnsInternalServerError()
        {
            // Arrange
            _sharePointApiServiceMock.Setup(mock => mock.GetDocumentTypes()).ThrowsAsync(new Exception());

            // Act
            var result = await _controller.GetDocumentTypes();

            // Assert
            Assert.IsType<StatusCodeResult>(result);
            Assert.Equal(StatusCodes.Status500InternalServerError, ((StatusCodeResult)result).StatusCode);
        }
    }
}
