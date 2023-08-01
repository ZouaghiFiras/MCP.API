using MCP.Services.Contracts;
using MCP.Services.DTO;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MCP.API.Controllers.Tests
{
    public class ContactControllerTests
    {
        private readonly ContactController _controller;
        private readonly Mock<IContactService> _emailServiceMock;

        public ContactControllerTests()
        {
            _emailServiceMock = new Mock<IContactService>();
            _controller = new ContactController(_emailServiceMock.Object);
        }

        [Fact]
        public void SendEmail_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var emailDto = new EmailDto();

            // Act
            var result = _controller.SendEmail(emailDto);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void SendEmail_NullEmailDto_ReturnsOkResult()
        {
            // Act
            var result = _controller.SendEmail(null);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void SendEmail_EmailServiceCalled()
        {
            // Arrange
            var emailDto = new EmailDto();

            // Act
            _controller.SendEmail(emailDto);

            // Assert
            _emailServiceMock.Verify(mock => mock.SendEmailAsync(emailDto), Times.Once);
        }
    }
}