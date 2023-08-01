
using MCP.API.Controllers;
using MCP.Services.Contracts;
using MCP.Services.DTO;
using Microsoft.AspNetCore.Mvc;
using Moq;

namespace MCP.API.Tests.Controllers
{
    public class ContactControllerTests
    {
        [Fact]
        public void SendEmail_ValidRequest_ReturnsOkResult()
        {
            // Arrange
            var emailServiceMock = new Mock<IContactService>();
            var controller = new ContactController(emailServiceMock.Object);
            var request = new EmailDto();

            // Act
            var result = controller.SendEmail(request);

            // Assert
            Assert.IsType<OkResult>(result);
        }

        [Fact]
        public void SendEmail_NullEmailService_ThrowsArgumentNullException()
        {
            // Arrange
            IContactService emailService = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => new ContactController(emailService));
        }

        [Fact]
        public void SendEmail_CallsSendEmailAsyncOnce()
        {
            // Arrange
            var emailServiceMock = new Mock<IContactService>();
            var controller = new ContactController(emailServiceMock.Object);
            var request = new EmailDto();

            // Act
            var result = controller.SendEmail(request);

            // Assert
            emailServiceMock.Verify(mock => mock.SendEmailAsync(request), Times.Once);
        }
    }
}