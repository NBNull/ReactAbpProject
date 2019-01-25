using Microsoft.AspNetCore.Antiforgery;
using ReactAbpProject.Controllers;

namespace ReactAbpProject.Web.Host.Controllers
{
    public class AntiForgeryController : ReactAbpProjectControllerBase
    {
        private readonly IAntiforgery _antiforgery;

        public AntiForgeryController(IAntiforgery antiforgery)
        {
            _antiforgery = antiforgery;
        }

        public void GetToken()
        {
            _antiforgery.SetCookieTokenAndHeader(HttpContext);
        }
    }
}
