using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Services;
using RockApi.Models;

namespace Rock.Controllers
{
    public class ReferralsController : Controller
    {
        public async Task<IActionResult> Index(string memberid)
        {
            var Service = new ReferralService();

            var Options = new List<QueryOption>()
            {
                new QueryOption("memberid", memberid)
            };

            var model = await Service.ListAsync<ReferralSet>(Options);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(string referralCode)
        {
            return View(new NewReferral() { referralCode = referralCode });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(NewReferral model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Service = new ReferralService();
                    await Service.CreateAsync(model);
                }
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(model);
            }
        }
        public async Task<IActionResult> Edit(string id)
        {
            var service = new ReferralService();

            var Options = new List<QueryOption>()
            {
                new QueryOption("referralQuery", id)
            };

            var model = await service.GetAsync(Options);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Referral model)
        {
            var service = new ReferralService();

            return View();
        }
    }
}