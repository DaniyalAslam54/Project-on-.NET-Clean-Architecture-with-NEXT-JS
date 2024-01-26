using HR.LeaveManagement.Application.Models.Email;

namespace HR.LeaveManagement.Application.Email;

public interface IEmailSender
{
    Task<bool> SendEmail(EmailMessage email);
}
