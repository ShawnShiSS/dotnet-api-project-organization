using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebAPI.Infrastructure.Services
{
    public interface IEmailService
    {
        Task SendEmailAsync(string from, string to, string subject, string plainTextContent, string htmlContent);
        Task SendEmailAsync(string from, List<string> to, string subject, string plainTextContent, string htmlContent);
    }
}
