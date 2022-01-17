using RockApi.Models;

namespace RockApi.Services
{
    public class MemberService : Service<Member>
    {
        public override string BasePath => "api/member";
    }
}