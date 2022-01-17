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
        public static string PublicKey = "e6de812d-32ec-4366-b719-21fd15ab1e48";
        public static string PrivateKey = "9b69c8a2-f95d-43f7-9512-fdeecbc5ffda";
        public static string AuthToken = "ZTZkZTgxMmQtMzJlYy00MzY2LWI3MTktMjFmZDE1YWIxZTQ4OjliNjljOGEyLWY5NWQtNDNmNy05NTEyLWZkZWVjYmM1ZmZkYQ==";

        public static void SetKeys(string PublicKey, string PrivateKey, string Auth)
        {
        }
        public static string Base64EncodeKeys(string PublicKey, string PrivateKey)
        {
            return string.Empty;
        }
    }
}