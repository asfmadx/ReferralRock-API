using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Rock.Models;
using RockApi.Services;
using RockApi.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Rock.Controllers
{
    public class MembersController : Controller
    {
        public readonly ILogger<MembersController> _logger;
        public MembersController(ILogger<MembersController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var MemberService = new MemberService();
            var model = await MemberService.ListAsync<MemberSet>();
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
