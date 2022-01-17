using System.Collections.Generic;

namespace RockApi.Models
{
    public class ReferralSet
    {
        public int offset { get; set; }
        public int total { get; set; }
        public string message { get; set; }
        public List<Referral> referrals { get; set; }
    }

    public class Referral
    {
        public string id { get; set; }
        public string displayName { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string fullName { get; set; }
        public string email { get; set; }
        public string externalIdentifier { get; set; }
        public string phoneNumber { get; set; }
        public double amount { get; set; }
        public string amountFormatted { get; set; }
        public string preferredContact { get; set; }
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string source { get; set; }
        public string programId { get; set; }
        public string programName { get; set; }
        public string programTitle { get; set; }
        public string referringMemberId { get; set; }
        public string referringMemberName { get; set; }
        public string memberEmail { get; set; }
        public string memberReferralCode { get; set; }
        public string memberExternalIdentifier { get; set; }
        public string approvedDate { get; set; }
        public string qualifiedDate { get; set; }
        public string status { get; set; }
        public string companyName { get; set; }
        public string note { get; set; }
        public string publicNote { get; set; }
        public string customOption1Name { get; set; }
        public string customOption2Name { get; set; }
        public string customText1Name { get; set; }
        public string customText2Name { get; set; }
        public string customText3Name { get; set; }
        public string customOption1Value { get; set; }
        public string customOption2Value { get; set; }
        public string customText1Value { get; set; }
        public string customText2Value { get; set; }
        public string customText3Value { get; set; }
        public string conversionNote { get; set; }
        public string conversionIPAddress { get; set; }
        public string utmSource { get; set; }
        public string utmMedium { get; set; }
        public string utmCampaign { get; set; }
        public string browserReferrerUrl { get; set; }
        public string IPAddressSource { get; set; }
    }

    public class NewReferral
    {
        public string referralCode { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string preferredContact { get; set; }
        public string externalIdentifier { get; set; }
        public double amount { get; set; }
        public string companyName { get; set; }
        public string note { get; set; }
        public string publicNote { get; set; }
        public string customOption1Name { get; set; }
        public string customOption2Name { get; set; }
        public string customText1Name { get; set; }
        public string customText2Name { get; set; }
        public string customText3Name { get; set; }
        public string customOption1Value { get; set; }
        public string customOption2Value { get; set; }
        public string customText1Value { get; set; }
        public string customText2Value { get; set; }
        public string customText3Value { get; set; }
        public string status { get; set; }
        //Other fields
    }

    public class UpdateReferral
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public string preferredContact { get; set; }
        public string externalIdentifier { get; set; }
        public double amount { get; set; }
        public string companyName { get; set; }
        public string note { get; set; }
        public string publicNote { get; set; }
        public string customOption1Name { get; set; }
        public string customOption2Name { get; set; }
        public string customText1Name { get; set; }
        public string customText2Name { get; set; }
        public string customText3Name { get; set; }
        public string customOption1Value { get; set; }
        public string customOption2Value { get; set; }
        public string customText1Value { get; set; }
        public string customText2Value { get; set; }
        public string customText3Value { get; set; }
        public string status { get; set; }
    }

    public class UpdateReferralInfo
    {
        public ReferralQuery query { get; set; }
        public UpdateReferral referral { get; set; }
    }

    public class ReferralQuery
    {
        public ReferralPrimaryInfo ReferralPrimaryInfo { get; set; }
        //public ReferralSecondaryInfo ReferralSecondaryInfo { get; set; }
        //public ReferralTertiaryInfo ReferralTertiaryInfo { get; set; }
        //public ReferralFuzzyInfo ReferralFuzzyInfo { get; set; }
    }
    public class ReferralPrimaryInfo
    {
        public string referraldi { get; set; }
    }
    //public class ReferralSecondaryInfo
    //{

    //}
    //public class ReferralTertiaryInfo
    //{

    //}
    //public class ReferralFuzzyInfo
    //{

    //}
}
