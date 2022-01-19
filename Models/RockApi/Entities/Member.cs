namespace RockApi
{
    public class Member : IRockEntity
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string externalIdentifier { get; set; }
        public string dateOfBirth { get; set; }
        public string addressLine1 { get; set; }
        public string addressLine2 { get; set; }
        public string city { get; set; }
        public string countrySubdivision { get; set; }
        public string country { get; set; }
        public string postalCode { get; set; }
        public bool disabledFlag { get; set; }
        public string customOverrideURL { get; set; }
        public PayoutInfo payoutInfo { get; set; }
        public string customOption1Name { get; set; }
        public string customOption1Value { get; set; }
        public string customText1Name { get; set; }
        public string customText1Value { get; set; }
        public string customText2Name { get; set; }
        public string customText2Value { get; set; }
        public string programId { get; set; }
        public string programTitle { get; set; }
        public string programName { get; set; }
        public string referralUrl { get; set; }
        public string referralCode { get; set; }
        public string memberUrl { get; set; }
        public int emailShares { get; set; }
        public int socialShares { get; set; }
        public int views { get; set; }
        public int referrals { get; set; }
        public string lastShare { get; set; }
        public int referralsApproved { get; set; }
        public int referralsQualified { get; set; }
        public int referralsPending { get; set; }
        public double referralsApprovedAmount { get; set; }
        public double rewardsPendingAmount { get; set; }
        public double rewardsIssuedAmount { get; set; }
        public double rewardAmountTotal { get; set; }
        public int rewards { get; set; }
        public string createDt { get; set; }
        public string utmSource { get; set; }
        public string utmMedium { get; set; }
        public string utmCampaign { get; set; }
        public string browserReferrerUrl { get; set; }
        public string lastViewIPAddress { get; set; }
    }
}