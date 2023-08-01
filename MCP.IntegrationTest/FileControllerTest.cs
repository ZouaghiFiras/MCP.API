using MCP.API.ViewModels;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Microsoft.AspNetCore.Http;
namespace MCP.API.Controllers.Tests
{
    public class FileControllerTests
    {
        private readonly FileController _controller;
        private readonly Mock<IFileService> _fileServiceMock;

        public FileControllerTests()
        {
            _fileServiceMock = new Mock<IFileService>();
            _controller = new FileController(_fileServiceMock.Object);
        }

        [Fact]
        public async Task Upload_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var uploadRequest = new UploadRequest
            {
                AssignmentNumber = "A123",
                Files = new List<IFormFile>() // Add the required files for testing
            };

            // Act
            var result = await _controller.Upload(uploadRequest);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Upload_NullFiles_ReturnsBadRequest()
        {
            // Arrange
            var uploadRequest = new UploadRequest
            {
                AssignmentNumber = "A123",
                Files = null
            };

            // Act
            var result = await _controller.Upload(uploadRequest);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var updateRequest = new UpdateRequest
            {
                AssignmentNumber = "A123",
                FileName = "file.txt",
                File = (IFormFile) new MemoryStream() // Add the required file for testing
            };

            // Act
            var result = await _controller.Update(updateRequest);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Update_NullFile_ReturnsBadRequest()
        {
            // Arrange
            var updateRequest = new UpdateRequest
            {
                AssignmentNumber = "A123",
                FileName = "file.txt",
                File = null
            };

            // Act
            var result = await _controller.Update(updateRequest);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Download_ValidRequest_ReturnsFileResult()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileName = "file.txt";
            var fileStream = new MemoryStream(); // Add the required file stream for testing
            _fileServiceMock.Setup(mock => mock.DownloadFile(assignmentNumber, fileName)).ReturnsAsync(fileStream);

            // Act
            var result = await _controller.Download(assignmentNumber, fileName);

            // Assert
            Assert.IsType<FileStreamResult>(result);
            Assert.Equal("application/octet-stream", ((FileStreamResult)result).ContentType);
            Assert.Equal(fileName, ((FileStreamResult)result).FileDownloadName);
        }

        [Fact]
        public async Task Download_NullFileStream_ReturnsNotFoundResult()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileName = "file.txt";
            _fileServiceMock.Setup(mock => mock.DownloadFile(assignmentNumber, fileName)).ReturnsAsync((Stream)null);

            // Act
            var result = await _controller.Download(assignmentNumber, fileName);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Delete_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileName = "file.txt";
            _fileServiceMock.Setup(mock => mock.DeleteFile(assignmentNumber, fileName)).ReturnsAsync(true);

            // Act
            var result = await _controller.Delete(assignmentNumber, fileName);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Delete_InvalidRequest_ReturnsNotFoundResult()
        {
            // Arrange
            var assignmentNumber = "A123";
            var fileName = "file.txt";
            _fileServiceMock.Setup(mock => mock.DeleteFile(assignmentNumber, fileName)).ReturnsAsync(false);

            // Act
            var result = await _controller.Delete(assignmentNumber, fileName);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetAll_ValidRequest_ReturnsOkResultWithFiles()
        {
            // Arrange
            var assignmentNumber = "A123";
            var files = new List<string> { /* Add the required files for testing */ };
            _fileServiceMock.Setup(mock => mock.GetAllFiles(assignmentNumber)).ReturnsAsync(files);

            // Act
            var result = await _controller.GetAll(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(files, ((OkObjectResult)result).Value);
        }

        [Fact]
        public async Task GetAll_InvalidRequest_ReturnsBadRequest()
        {
            // Arrange
            var assignmentNumber = "";

            // Act
            var result = await _controller.GetAll(assignmentNumber);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetPhotos_ValidRequest_ReturnsOkResultWithPhotos()
        {
            // Arrange
            var assignmentNumber = "A123";
            var photos = new List<string> { /* Add the required photos for testing */ };
            _fileServiceMock.Setup(mock => mock.GetPhotos(assignmentNumber)).ReturnsAsync(photos);

            // Act
            var result = await _controller.GetPhotos(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(photos, ((OkObjectResult)result).Value);
        }

        [Fact]
        public async Task GetPhotos_InvalidRequest_ReturnsBadRequest()
        {
            // Arrange
            var assignmentNumber = "";

            // Act
            var result = await _controller.GetPhotos(assignmentNumber);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetDocuments_ValidRequest_ReturnsOkResultWithDocuments()
        {
            // Arrange
            var assignmentNumber = "A123";
            var documents = new List<string> { /* Add the required documents for testing */ };
            _fileServiceMock.Setup(mock => mock.GetDocuments(assignmentNumber)).ReturnsAsync(documents);

            // Act
            var result = await _controller.GetDocuments(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            Assert.Equal(documents, ((OkObjectResult)result).Value);
        }

        [Fact]
        public async Task GetDocuments_InvalidRequest_ReturnsBadRequest()
        {
            // Arrange
            var assignmentNumber = "";

            // Act
            var result = await _controller.GetDocuments(assignmentNumber);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }
    }
}
