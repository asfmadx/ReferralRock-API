using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace RockApi
{
    public class Referral : IRockEntity
    {
        public string id { get; set; }

        [Display(Name = "Display Name")]
        public string displayName { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Full Name")]
        public string fullName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }

        [Display(Name = "External ID")]
        public string externalIdentifier { get; set; }

        [Display(Name = "Phone Number")]
        public string phoneNumber { get; set; }

        [Display(Name = "Amount")]
        public double amount { get; set; }

        [Display(Name = "Preferred Contact")]
        public string preferredContact { get; set; }

        [Display(Name = "Status")]
        public string status { get; set; }

        [Display(Name = "Company")]
        public string companyName { get; set; }

        [Display(Name = "Note")]
        public string note { get; set; }

        [Display(Name = "Public Note")]
        public string publicNote { get; set; }

        [Display(Name = "Custom Option 1 Name")]
        public string customOption1Name { get; set; }

        [Display(Name = "Custom Option 2 Name")]
        public string customOption2Name { get; set; }

        [Display(Name = "Custom Text 1 Name")]
        public string customText1Name { get; set; }

        [Display(Name = "Custom Text 2 Name")]
        public string customText2Name { get; set; }

        [Display(Name = "Custom Text 3 Name")]
        public string customText3Name { get; set; }


        [Display(Name = "Custom Option 1 Value")]
        public string customOption1Value { get; set; }

        [Display(Name = "Custom Option 2 Value")]
        public string customOption2Value { get; set; }

        [Display(Name = "Custom Text 1 Value")]
        public string customText1Value { get; set; }

        [Display(Name = "Custom Text 2 Value")]
        public string customText2Value { get; set; }

        [Display(Name = "Custom Text 3 Value")]
        public string customText3Value { get; set; }

        //Not included in view
        public string createDate { get; set; }
        public string updateDate { get; set; }
        public string amountFormatted { get; set; }
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
        [Display(Name = "Referral Code")]
        public string referralCode { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Email")]
        public string email { get; set; }
    }
}
