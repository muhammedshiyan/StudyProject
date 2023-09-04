
using projectmailapi.models;

public interface IMailService
{
        Task SendEmailAsync(MailRequest mailRequest);
    Task SendWelcomeEmailAsync(WelcomeRequest request);
}

