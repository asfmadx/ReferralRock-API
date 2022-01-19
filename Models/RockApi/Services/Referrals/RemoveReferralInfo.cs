namespace RockApi
{
    public class RemoveReferralInfo
    {
        public RemoveReferralInfo() { }

        //Default constructor to simplify searching by only referralid
        public RemoveReferralInfo(string referralid)
        {
            query = new ReferralQuery()
            {
                primaryInfo = new ReferralPrimaryInfo()
                {
                    referralId = referralid,
                }
            };
        }
        public ReferralQuery query { get; set; }
    }
}
