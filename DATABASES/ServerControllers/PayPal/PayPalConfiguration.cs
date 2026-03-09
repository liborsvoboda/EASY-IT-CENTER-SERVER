using PayPal.Api;
using System.Collections.Generic;

namespace Paypal_Integration.Services
{
    public static class PayPalConfiguration
    {
        public readonly static string ClientId;
        public readonly static string ClientSecret;

        /// <summary>
        /// PayPal Configuration
        /// </summary>
        static PayPalConfiguration()
        {
            ClientId = DbOperations.GetServerParameterLists("PayPalClientID").Value;
            ClientSecret = DbOperations.GetServerParameterLists("PayPalSecretKey").Value;
        }

        /// <summary>
        /// Get PayPal Config
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, string> GetConfig()
        {
            return new Dictionary<string, string>() {
                { "clientId", DbOperations.GetServerParameterLists("PayPalClientID").Value },
                { "clientSecret", DbOperations.GetServerParameterLists("PayPalSecretKey").Value }
            };
        }

        /// <summary>
        /// Create accessToken
        /// </summary>
        /// <returns></returns>
        private static string GetAccessToken()
        {               
            string accessToken = new OAuthTokenCredential
                (ClientId, ClientSecret, GetConfig()).GetAccessToken();
            return accessToken;
        }


        /// <summary>
        /// Returns APIContext object
        /// </summary>
        /// <param name="accessToken"></param>
        /// <returns></returns>
        public static APIContext GetAPIContext(string accessToken = "")
        {
            var apiContext = new APIContext(string.IsNullOrEmpty(accessToken) ?
                GetAccessToken() : accessToken);
            apiContext.Config = GetConfig();
            
            return apiContext;
        }
    }
}
