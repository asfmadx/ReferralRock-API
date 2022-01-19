using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RockApi
{
    public class ReferralQuery
    {
        public ReferralPrimaryInfo primaryInfo { get; set; }
        public ReferralSecondaryInfo secondaryInfo { get; set; }
        public ReferralTertiaryInfo tertiaryInfo { get; set; }
        public ReferralFuzzyInfo fuzzyInfo { get; set; }
    }
    public class ReferralPrimaryInfo
    {
        public string referralId { get; set; }
    }
    public class ReferralSecondaryInfo
    {
        public string externalIdentifier { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
    }
    public class ReferralTertiaryInfo
    {
        public string ProgramId { get; set; }
        public string ProgramName { get; set; }
        public string ProgramTitle { get; set; }
    }
    public class ReferralFuzzyInfo
    {
        public string Identifier { get; set; }
    }
}
