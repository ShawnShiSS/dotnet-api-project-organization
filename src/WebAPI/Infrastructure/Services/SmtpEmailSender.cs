using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Infrastructure.Services
{
    public class SmtpEmailSender : IEmailService
    {
        public Task SendEmailAsync(string from, string to, string subject, string plainTextContent, string htmlContent)
        {
            throw new System.NotImplementedException();
        }

        public Task SendEmailAsync(string from, List<string> to, string subject, string plainTextContent, string htmlContent)
        {
            throw new System.NotImplementedException();
        }
    }

}
