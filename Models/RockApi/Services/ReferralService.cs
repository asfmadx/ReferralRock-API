using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RockApi.Models;

namespace RockApi.Services
{
    public class ReferralService : Service<Referral>
    {
        public override string BasePath => "api/referral";
    }
}
