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
        protected override string ListPath => "api/referrals";
        protected override string GetSinglePath => "api/referral/getsingle";
        protected override string CreatePath => "api/referrals";
        protected override string UpdatePath => "api/referral/update";
        protected override string RemovePath => "api/referral/remove";

        /// <summary>
        ///  List
        /// </summary>
        /// <param name="QueryOptions">A collection of query string parameters</param>
        /// <returns>A collection of members</returns>
        public async Task<List<Referral>> ListAsync(QueryOptions QueryOptions = null)
        {
            var ReferralSet = await this.ListEntitiesAsync<ReferralSet>(QueryOptions);
            return ReferralSet.referrals.ToList();
        }

        /// <summary>
        ///  Get
        /// </summary>
        /// <param name="QueryOptions">A collection of query string parameters</param>
        /// <returns>A single member</returns>
        public Task<Referral> GetAsync(QueryOptions QueryOptions = null)
        {
            return this.GetEntityAsync(QueryOptions);
        }

        /// <summary>
        /// Create
        /// </summary>
        /// <param name="NewReferral">A referral to create</param>
        /// <returns></returns>
        public async Task CreateAsync(NewReferral NewReferral)
        {
            await this.CreateEntityAsync(NewReferral);
        }

        /// <summary>
        /// Update
        /// </summary>
        /// <param name="UpdateReferralInfos">An update object that contains a query object to identify the referral to update and a referral object with the new values</param>
        /// <returns></returns>
        public async Task UpdateAsync(List<UpdateReferralInfo> UpdateReferralInfos)
        {
            await this.UpdateEntityAsync(UpdateReferralInfos);
        }

        /// <summary>
        /// Delete
        /// </summary>
        /// <param name="UpdateReferralInfos">An delete object that contains a query object to identify the referral to delete</param>
        /// <returns></returns>
        public async Task RemoveAsync(List<RemoveReferralInfo> RemoveReferralInfos)
        {
            await this.RemoveEntityAsync(RemoveReferralInfos);
        }
    }
}
