using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace WebServer.Controllers
{
    public class AccountController : Controller
    {
        public async Task Logout()
        {
            await HttpContext.Authentication.SignOutAsync("Webserver.Cookies");
            await HttpContext.Authentication.SignOutAsync("oidc");
        }
    }
}
