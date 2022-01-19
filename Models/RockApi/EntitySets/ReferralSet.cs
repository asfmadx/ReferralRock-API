using System.Collections.Generic;

namespace RockApi.Models
{
    /// <summary>
    /// Object returned by the API. Contains a collections of referrals and other info
    /// </summary>
    public class ReferralSet : IRockEntitySet
    {
        public int offset { get; set; }
        public int total { get; set; }
        public string message { get; set; }
        public List<Referral> referrals { get; set; }
    }
}