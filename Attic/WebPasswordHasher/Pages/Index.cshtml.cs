using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

using MailKit;
using MailKit.Net.Smtp;
using MimeKit;

namespace WebPasswordHasher.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        [BindProperty]
        public User NewUser { get; set; }

        public async Task OnGet()
        {
            NewUser = new User();

            await SendEmailAsync();
        }

        public void OnPost()
        {
            var pwdHasher = new PasswordHasher<User>();

            NewUser.HashedPassword = pwdHasher.HashPassword(NewUser, NewUser.OriginalPassword);
        }

        private async Task SendEmailAsync()
        {
            try
            {
                var strSb = new StringBuilder();

                strSb.Append("<span style='font=size:25pt'>هذه رسالة من موقع شركة أول المستقبل المتقدم للتدريب.</span><br />");
                strSb.Append("لقد قمت بإنشاء حسابك بنجاح. وبقي خطوة واحدة وهي تفعيل الحساب. <br />");
                strSb.Append("انسخ هذا الرمز وضعه في صفحة تأكيد البريد في الموقع. <br />");
                strSb.Append($"<span style='color:white; background-color:black'><b>015Ab3cZ</b></span>");

                var bodyBuilder = new BodyBuilder() { HtmlBody = strSb.ToString() };

                var mailMsg = new MimeMessage();

                mailMsg.From.Add(new MailboxAddress("One Dot Learn", "info@onedotlearn.com"));
                mailMsg.From.Add(new MailboxAddress("وليد", "waleedmmnasser@hotmail.com"));
                mailMsg.Subject = "لتفعيل حسابك في موقع شركة أول المستقبل المتقدم للتدريب";
                mailMsg.Body = bodyBuilder.ToMessageBody();

                using var smtpClnt = new MailKit.Net.Smtp.SmtpClient();

                await smtpClnt.ConnectAsync("smtp.gmail.com", 587);
                await smtpClnt.AuthenticateAsync("walghadamsy@gmail.com", "1WorkingWell");

                await smtpClnt.SendAsync(mailMsg); await smtpClnt.DisconnectAsync(true);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}