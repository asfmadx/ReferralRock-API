using RestSharp;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace RockApi.Services
{
    public abstract class Service<T>
    {
        public abstract string BasePath { get; }
        protected RestClient Client;
        protected Service()
        {
            Client = new RestClient(RockAPIConfig.ApiBase);
        }

        private string BasePathPlural => $"{BasePath}s";

        public virtual async Task<TListType> ListAsync<TListType>(List<QueryOption> Options = null)
        {
            var request = new RestRequest(BasePathPlural, Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {RockAPIConfig.AuthToken}");
            if (Options != null)
            {
                Options.ForEach(f => request.AddQueryParameter(f.Parameter, f.Value));
            }
            return await Client.GetAsync<TListType>(request);
        }

        public virtual async Task CreateAsync(object model)
        {
            var request = new RestRequest(BasePathPlural, Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {RockAPIConfig.AuthToken}");
            request.AddBody(model);
            _ = await Client.ExecuteAsync(request);
        }

        /// <summary>
        /// This method is only available on "api/referral".  No not use on "api/member"
        /// </summary>
        /// <param name="Options"></param>
        /// <returns></returns>
        public virtual async Task<T> GetAsync(List<QueryOption> Options = null)
        {
            //The method getsingle is not available for all endpoints.  
            var request = new RestRequest($"{BasePath}/getsingle", Method.Get);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {RockAPIConfig.AuthToken}");
            if (Options != null)
            {
                Options.ForEach(f => request.AddQueryParameter(f.Parameter, f.Value));
            }
            return await Client.GetAsync<T>(request);
        }

        public virtual async Task UpdateAsync()
        {
            var request = new RestRequest($"{BasePath}/update", Method.Post);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {RockAPIConfig.AuthToken}");



            _ = await Client.PostAsync(request);
        }
    }

    public class QueryOption
    {
        public QueryOption(string Parameter, string Value)
        {
            this.Parameter = Parameter;
            this.Value = Value;
        }

        public string Parameter { get; }
        public string Value { get; }
    }
}