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
        /// 这是一个演示代码，演示向默认租户管理员和主机管理员发送通知
        /// This is a demo code to demonstrate sending notification to default tenant admin and host admin uers.
        /// 不要在生产中使用此代码 !!!
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public async Task<ActionResult> TestNotification(string message = "")
        {
            if (message.IsNullOrEmpty())
            {
                message = "这是一个测速通知, 创建时间 " + Clock.Now;
            }
            //根据租户Id和用户Id得到标识用户
            var defaultTenantAdmin = new UserIdentifier(1, 2);
            var hostAdmin = new UserIdentifier(null, 1);
            //发布异步消息
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
