// Bring in the necessary namespaces for the classes and interfaces used in this code
using MailKit.Net.Smtp;
using MailKit.Security;
using MCP.Services.Contracts;
using MCP.Services.DTO;
using Microsoft.Extensions.Configuration;
using MimeKit;

namespace MCP.Services.Components
{
    /// <summary>
    ///     Service class for sending emails.
    /// </summary>
    public class ContactService : IContactService
    {
        private readonly IConfiguration _config;

        /// <summary>
        ///     Initializes a new instance of the ContactService class.
        /// </summary>
        /// <param name="configuration">The configuration settings for the email service.</param>
        public ContactService(IConfiguration configuration)
        {
            _config = configuration;
        }

        /// <summary>
        ///     Sends an email using the specified email details.
        /// </summary>
        /// <param name="request">The details of the email to be sent.</param>
        /// <returns>True if the email was sent successfully; otherwise, false.</returns>
        public async Task<bool> SendEmailAsync(EmailDto request)
        {
            try
            {
                // Create a new email message
                var email = new MimeMessage();
                email.From.Add(MailboxAddress.Parse(_config.GetSection("Email:Username").Value));
                email.To.Add(MailboxAddress.Parse(request.To));
                email.Subject = request.Subject;

                // Create the body of the email
                var bodyBuilder = new BodyBuilder();

                // Add the application name and description to the email
                bodyBuilder.HtmlBody += @"
                    <div class='text-center'>
                        <h1 class='font-weight-bold'>CED Client Portal</h1>
                    </div>";

                // Add the main text of the email
                bodyBuilder.HtmlBody += $@"
                    <div style='margin-top: 20px;'>
                        <p>Dear {request.ToName},</p>
                        <p>{request.Body}</p>
                        <p>Please visit the MCP website to log in using your credentials:</p>
                        <div class='text-center'>
                            <a href='http://localhost:4200/' class='btn btn-primary'>Log In to MCP</a>
                        </div>
                    </div>";

                // Add the MCP logo to the email
                bodyBuilder.HtmlBody += @"
                    <div class='text-center' style='margin: 10px;'>
                        <img src='https://www.infinance.nl/wp-content/uploads/2016/11/CED-logo-300x180.jpg' style='width: 100px; height: 100px;'>
                    </div>";

                // Set the body of the email and specify that it's HTML
                email.Body = bodyBuilder.ToMessageBody();

                // Create a new SMTP client and send the email
                using (var smtp = new SmtpClient())
                {
                    smtp.Connect(_config.GetSection("Email:Host").Value, 587, SecureSocketOptions.StartTls);
                    smtp.Authenticate(_config.GetSection("Email:Username").Value,
                        _config.GetSection("Email:Password").Value);
                    smtp.Send(email);
                    smtp.Disconnect(true);
                }

                return true;
            }
            catch (Exception ex)
            {
                // Log the exception and return false
                // You can replace Console.WriteLine with your preferred logging mechanism
                Console.WriteLine($"Error sending email: {ex.Message}");
                return false;
            }
        }

    }
}