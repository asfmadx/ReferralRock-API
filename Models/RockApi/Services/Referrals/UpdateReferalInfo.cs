namespace RockApi
{
    /// <summary>
    /// UpdateReferralInfo is passed to ReferralService.Update()
    /// </summary>
    public class UpdateReferralInfo
    {
        public UpdateReferralInfo() { }

        //Constructor to simplify searching by only referralid
        public UpdateReferralInfo(Referral referralObject)
        {
            query = new ReferralQuery()
            {
                primaryInfo = new ReferralPrimaryInfo()
                {
                    referralId = referralObject.id
                }
            };
            referral = referralObject;
        }
        public ReferralQuery query { get; set; }
        public Referral referral { get; set; }
    }
}
