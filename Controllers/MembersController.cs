using Microsoft.AspNetCore.Mvc;
using RockApi.Services;
using System.Threading.Tasks;

namespace Rock.Controllers
{
    public class MembersController : Controller
    {
        public async Task<IActionResult> Index()
        {
            try
            {
                var MemberService = new MemberService();
                var model = await MemberService.ListAsync();
                return View(model);
            }
            catch
            {
                return View();
            }
        }
    }
}
