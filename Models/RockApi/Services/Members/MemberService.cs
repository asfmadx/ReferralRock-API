using RockApi.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi.Services
{
    public class MemberService : Service<Member> 
    {
        protected override string ListPath => "api/members";
        protected override string GetSinglePath => "";
        protected override string CreatePath => "api/members";
        protected override string UpdatePath => "api/members/update";
        protected override string RemovePath => "api/members/remove";


        /// <summary>
        /// Returns a collection of members
        /// </summary>
        /// <param name="QueryOptions">A collection of query string parameters</param>
        /// <returns></returns>
        public async Task<List<Member>> ListAsync(QueryOptions QueryOptions = null)
        {
            var MemberSet = await this.ListEntitiesAsync<MemberSet>(QueryOptions);
            return MemberSet.members.ToList();
        }
    }
}