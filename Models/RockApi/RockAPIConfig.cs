using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;

namespace RockApi
{
    public static class RockAPIConfig
    {
        public static string ApiBase = "https://api.referralrock.com";
        public static string PublicKey = "";
        public static string PrivateKey = "";
        public static string AuthToken = "";

        public static void SetKeys(string PublicKey, string PrivateKey, string Auth)
        {
        }
        public static string Base64EncodeKeys(string PublicKey, string PrivateKey)
        {
            //Not implemented
            return AuthToken;
        }
    }
}