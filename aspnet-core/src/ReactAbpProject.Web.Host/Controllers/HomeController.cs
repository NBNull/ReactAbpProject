using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp;
using Abp.Extensions;
using Abp.Notifications;
using Abp.Timing;
using ReactAbpProject.Controllers;

namespace ReactAbpProject.Web.Host.Controllers
{
    public class HomeController : ReactAbpProjectControllerBase
    {
        private readonly INotificationPublisher _notificationPublisher;

        public HomeController(INotificationPublisher notificationPublisher)
        {
            _notificationPublisher = notificationPublisher;
        }

        public IActionResult Index()
        {
            return Redirect("/swagger");
        }

        /// <summary>
        /// ����һ����ʾ���룬��ʾ��Ĭ���⻧����Ա����������Ա����֪ͨ
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// ��Ҫ��������ʹ�ô˴��� !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "����һ������֪ͨ, ����ʱ�� " + Clock.Now;
            }
            //�����⻧Id���û�Id�õ���ʶ�û�
            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);
            //�����첽��Ϣ
            await _notificationPublisher.PublishAsync(
                "App.SimpleMessage",
                new MessageNotificationData(message),
                severity: NotificationSeverity.Info,
                userIds: new[] { defaultTenantAdmin, hostAdmin }
            );

            return Content("Sent notification: " + message);
        }
    }
}
