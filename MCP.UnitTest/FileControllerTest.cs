
using MCP.API.Controllers;
using MCP.API.ViewModels;
using MCP.Services.Contracts;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MCP.API.Tests.Controllers
{
    public class FileControllerTests
    {
        private readonly Mock<IFileService> _fileServiceMock;
        private readonly FileController _controller;

        public FileControllerTests()
        {
            _fileServiceMock = new Mock<IFileService>();
            _controller = new FileController(_fileServiceMock.Object);
        }

        [Fact]
        public async Task Upload_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var request = new UploadRequest
            {
                AssignmentNumber = "123",
                Files = new List<IFormFile> { CreateTestFormFile() }
            };

            // Act
            var result = await _controller.Upload(request);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Upload_NoFiles_ReturnsBadRequestResult()
        {
            // Arrange
            var request = new UploadRequest
            {
                AssignmentNumber = "123",
                Files = null
            };

            // Act
            var result = await _controller.Upload(request);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Update_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var request = new UpdateRequest
            {
                AssignmentNumber = "123",
                FileName = "test.jpg",
                File = CreateTestFormFile()
            };

            // Act
            var result = await _controller.Update(request);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Update_NoFile_ReturnsBadRequestResult()
        {
            // Arrange
            var request = new UpdateRequest
            {
                AssignmentNumber = "123",
                FileName = "test.jpg",
                File = null
            };

            // Act
            var result = await _controller.Update(request);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Download_ValidRequest_ReturnsFileStreamResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var fileName = "test.jpg";
            var fileStream = new MemoryStream();

            _fileServiceMock.Setup(mock => mock.DownloadFile(assignmentNumber, fileName))
                .ReturnsAsync(fileStream);

            // Act
            var result = await _controller.Download(assignmentNumber, fileName);

            // Assert
            Assert.IsType<FileStreamResult>(result);
            Assert.Equal("application/octet-stream", ((FileStreamResult)result).ContentType);
            Assert.Equal(fileName, ((FileStreamResult)result).FileDownloadName);
            Assert.Equal(fileStream, ((FileStreamResult)result).FileStream);
        }

        [Fact]
        public async Task Download_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange
            var fileName = "test.jpg";

            // Act
            var result = await _controller.Download(null, fileName);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Download_MissingFileName_ReturnsBadRequestResult()
        {
            // Arrange
            var assignmentNumber = "123";

            // Act
            var result = await _controller.Download(assignmentNumber, null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Download_FileNotFound_ReturnsNotFoundResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var fileName = "test.jpg";

            _fileServiceMock.Setup(mock => mock.DownloadFile(assignmentNumber, fileName))
                .ReturnsAsync((Stream)null);

            // Act
            var result = await _controller.Download(assignmentNumber, fileName);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task Delete_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var fileName = "test.jpg";

            _fileServiceMock.Setup(mock => mock.DeleteFile(assignmentNumber, fileName))
                .ReturnsAsync(true);

            // Act
            var result = await _controller.Delete(assignmentNumber, fileName);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public async Task Delete_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange
            var fileName = "test.jpg";

            // Act
            var result = await _controller.Delete(null, fileName);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Delete_MissingFileName_ReturnsBadRequestResult()
        {
            // Arrange
            var assignmentNumber = "123";

            // Act
            var result = await _controller.Delete(assignmentNumber, null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task Delete_FileNotFound_ReturnsNotFoundResult()
        {
            // Arrange
            var assignmentNumber = "123";
            var fileName = "test.jpg";

            _fileServiceMock.Setup(mock => mock.DeleteFile(assignmentNumber, fileName))
                .ReturnsAsync(false);

            // Act
            var result = await _controller.Delete(assignmentNumber, fileName);

            // Assert
            Assert.IsType<NotFoundResult>(result);
        }

        [Fact]
        public async Task GetAll_ValidRequest_ReturnsOkResultWithFiles()
        {
            // Arrange
            var assignmentNumber = "123";
            var files = new List<string> { "file1.txt", "file2.jpg", "file3.pdf" };

            _fileServiceMock.Setup(mock => mock.GetAllFiles(assignmentNumber))
                .ReturnsAsync(files);

            // Act
            var result = await _controller.GetAll(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(files, okResult.Value);
        }

        [Fact]
        public async Task GetAll_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange

            // Act
            var result = await _controller.GetAll(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetPhotos_ValidRequest_ReturnsOkResultWithPhotos()
        {
            // Arrange
            var assignmentNumber = "123";
            var photos = new List<string> { "photo1.jpg", "photo2.png" };

            _fileServiceMock.Setup(mock => mock.GetPhotos(assignmentNumber))
                .ReturnsAsync(photos);

            // Act
            var result = await _controller.GetPhotos(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(photos, okResult.Value);
        }

        [Fact]
        public async Task GetPhotos_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange

            // Act
            var result = await _controller.GetPhotos(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        [Fact]
        public async Task GetDocuments_ValidRequest_ReturnsOkResultWithDocuments()
        {
            // Arrange
            var assignmentNumber = "123";
            var documents = new List<string> { "document1.docx", "document2.pdf" };

            _fileServiceMock.Setup(mock => mock.GetDocuments(assignmentNumber))
                .ReturnsAsync(documents);

            // Act
            var result = await _controller.GetDocuments(assignmentNumber);

            // Assert
            Assert.IsType<OkObjectResult>(result);
            var okResult = (OkObjectResult)result;
            Assert.Equal(documents, okResult.Value);
        }

        [Fact]
        public async Task GetDocuments_MissingAssignmentNumber_ReturnsBadRequestResult()
        {
            // Arrange

            // Act
            var result = await _controller.GetDocuments(null);

            // Assert
            Assert.IsType<BadRequestResult>(result);
        }

        private IFormFile CreateTestFormFile()
        {
            var content = "Test file content";
            var fileName = "test.txt";
            var memoryStream = new MemoryStream();
            var writer = new StreamWriter(memoryStream);
            writer.Write(content);
            writer.Flush();
            memoryStream.Position = 0;

            return new FormFile(memoryStream, 0, memoryStream.Length, "file", fileName);
        }
    }
}
