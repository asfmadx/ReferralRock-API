using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Services;
using RockApi;

namespace Rock.Controllers
{
    public class ReferralsController : Controller
    {
        public async Task<IActionResult> Index(string referralcode, string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
            var Service = new ReferralService();

            var QueryOptions = new QueryOptions();
            QueryOptions.Options.Add(new QueryOption("query", referralcode));

            var model = await Service.ListAsync(QueryOptions);
            return View(model);
        }

        [HttpGet]
        public IActionResult Create(string referralCode, string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
            return View(new NewReferral() { referralCode = referralCode });
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("referralCode,firstName,lastName,email")] NewReferral model, string returnUrl)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var Service = new ReferralService();
                    await Service.CreateAsync(model);
                }
                if (Url.IsLocalUrl(returnUrl)) return Redirect(returnUrl);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
                return View(model);
            }
        }
        public async Task<IActionResult> Edit(string id, string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
            var Service = new ReferralService();

            var QueryOptions = new QueryOptions();
            QueryOptions.Options.Add(new QueryOption("referralQuery", id));

            Referral model = await Service.GetAsync(QueryOptions);
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Referral model, string returnUrl)
        {
            try
            {
                var Service = new ReferralService();
                await Service.UpdateAsync(new List<UpdateReferralInfo>() { new UpdateReferralInfo(model) });

                if (Url.IsLocalUrl(returnUrl)) return Redirect(returnUrl);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
                return View(model);
            }
        }

        [HttpGet]
        public ActionResult Delete(string id, string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
            return View();
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id, string returnUrl)
        {
            try
            {
                var Service = new ReferralService();
                await Service.RemoveAsync(new List<RemoveReferralInfo> { new RemoveReferralInfo(id) });

                if (Url.IsLocalUrl(returnUrl)) return Redirect(returnUrl);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                if (Url.IsLocalUrl(returnUrl)) ViewData["returnUrl"] = returnUrl;
                return View();
            }
        }
    }
}