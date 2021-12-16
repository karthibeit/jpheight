using JPBlazor.Application.Requests.Mail;
using System.Threading.Tasks;

namespace JPBlazor.Application.Interfaces.Services
{
    public interface IMailService
    {
        Task SendAsync(MailRequest request);
    }
}