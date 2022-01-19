using RestSharp;
using System.Threading.Tasks;

namespace RockApi
{
    public abstract class Service<T> where T : IRockEntity
    {
        //Different paths used by the api. Derived services will override these  
        protected abstract string ListPath { get; } //GET
        protected abstract string GetSinglePath { get; } //GET
        protected abstract string CreatePath { get; } //POST
        protected abstract string UpdatePath { get; } //POST
        protected abstract string RemovePath { get; } //DELETE


        protected RestClient Client;
        protected Service()
        {
            Client = new RestClient(RockAPIConfig.ApiBase);
        }

        /// <summary>
        /// List method
        /// </summary>
        /// <typeparam name="TListType">An api set</typeparam>
        /// <param name="Options">A collection of query string parameters</param>
        /// <returns>An api set of the requested type</returns>
        protected async Task<TListType> ListEntitiesAsync<TListType>(QueryOptions Options = null) where TListType : IRockEntitySet
        {
            var response = await this.MakeRequest<TListType>(ListPath, Method.Get, null, Options);
            return response.Data;
        }

        /// <summary>
        /// Get single method
        /// </summary>
        /// <param name="Options">A collection of query string parameters</param>
        /// <returns>A single instance of type T</returns>
        protected async Task<T> GetEntityAsync(QueryOptions Options = null)
        {
            var response = await this.MakeRequest<T>(GetSinglePath, Method.Get, null, Options);
            return response.Data;
        }

        /// <summary>
        /// Create method
        /// </summary>
        /// <param name="CreateModel">An instance of type T to create</param>
        /// <returns></returns>
        protected async Task CreateEntityAsync(object CreateModel)
        {
            _ = await this.MakeRequest<RestResponse>(CreatePath, Method.Post, CreateModel);
        }

        /// <summary>
        /// Update method
        /// </summary>
        /// <param name="UpdateInfo">An update object that gets added to the request body</param>
        /// <returns></returns>
        protected async Task UpdateEntityAsync(object UpdateInfo)
        {
            _ = await this.MakeRequest<RestResponse>(UpdatePath, Method.Post, UpdateInfo);
        }

        /// <summary>
        /// Remove method
        /// </summary>
        /// <param name="RemoveInfo">A remove object that gets added to the request body</param>
        /// <returns></returns>
        protected async Task RemoveEntityAsync(object RemoveInfo)
        {
            _ = await this.MakeRequest<RestResponse>(RemovePath, Method.Post, RemoveInfo);
        }


        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="Path">The api path</param>
        /// <param name="httpMethod">The http method</param>
        /// <param name="Model">A model, if applicable, to be added to the reqyest body</param>
        /// <param name="Options">A collection of query string parameters</param>
        /// <returns></returns>
        private async Task<RestResponse<TResponse>> MakeRequest<TResponse>(string Path, Method httpMethod, object Model = null, QueryOptions Options = null)
        {
            var request = new RestRequest(Path, httpMethod);
            request.AddHeader("Content-Type", "application/json");
            request.AddHeader("Authorization", $"Basic {RockAPIConfig.AuthToken}");
            if (Model != null)
            {
                request.AddBody(Model);
            }
            if (Options != null)
            {
                Options.Options.ForEach(f => request.AddQueryParameter(f.Parameter, f.Value));
            }
            return await Client.ExecuteAsync<TResponse>(request);
        }
    }

}