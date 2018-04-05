using System.Threading.Tasks;

namespace MBaumann.ConfNet.WebMvc.Services
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }
}
