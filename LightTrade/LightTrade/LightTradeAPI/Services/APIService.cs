using LightTrade.LightTradeAPI.HTTP_Models;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LightTrade.LightTradeAPI.Services
{
    public class APIService<T>
    {
        private string apiUrl;
        private string path;
        private string authToken;
        private IRestClient client;
        public APIService(string apiUrl, string path, string authToken = null)
        {
            this.apiUrl = apiUrl;
            this.path = path;
            this.authToken = authToken;
            client = new RestClient(this.apiUrl);

        }
        public async Task<List<T>> GetByPage(int page)
        {
            CancellationToken cancellationToken = new CancellationToken();
            IRestRequest request = new RestRequest(path + "/" + page.ToString(), DataFormat.Json);
            request.AddHeader("Authorization", authToken);
            return await client.GetAsync<List<T>>(request, cancellationToken);
        }

        public async Task<List<T>> GetAll()
        {
            CancellationToken cancellationToken = new CancellationToken();
            IRestRequest request = new RestRequest(path, DataFormat.Json);
            request.AddHeader("Authorization", authToken);
            return await client.GetAsync<List<T>>(request, cancellationToken);
        }

        public async Task<List<T>> GetAllByParams(List<string> paramsList, string additionalPath = null)
        {
            CancellationToken cancellationToken = new CancellationToken();
            string curPath = path;
            if (additionalPath != null)
                curPath = path + additionalPath;
            
            foreach (string param in paramsList)
            {
                curPath += "/" + param;
            }
            IRestRequest request = new RestRequest(curPath, DataFormat.Json);
            request.AddHeader("Authorization", authToken);
            return await client.GetAsync<List<T>>(request, cancellationToken);
        }

        public async Task<T> GetByParams(List<string> paramsList, string additionalPath = null)
        {
            CancellationToken cancellationToken = new CancellationToken();
            string curPath = path;
            if (additionalPath != null)
                curPath = path + additionalPath;

            foreach (string param in paramsList)
            {
                curPath += "/" + param;
            }
            IRestRequest request = new RestRequest(curPath, DataFormat.Json);
            request.AddHeader("Authorization", authToken);

            return await client.GetAsync<T>(request, cancellationToken);
        }

        public async Task<ServerResponse> Create(T model)
        {
            CancellationToken cancellationToken = new CancellationToken();
            IRestRequest request = new RestRequest(path, DataFormat.Json);
            request.AddHeader("Authorization", authToken);
            request.AddJsonBody(model);
            return await client.PostAsync<ServerResponse>(request, cancellationToken);
        }

        public async Task<ServerResponse> Update(string id, T model)
        {
            CancellationToken cancellationToken = new CancellationToken();
            IRestRequest request = new RestRequest(path + "/" + id, DataFormat.Json);
            request.AddHeader("Authorization", authToken);
            request.AddJsonBody(model);
            return await client.PutAsync<ServerResponse>(request, cancellationToken);
        }

        public async Task<ServerResponse> Delete(string id)
        {
            CancellationToken cancellationToken = new CancellationToken();
            IRestRequest request = new RestRequest(path + "/" + id, DataFormat.Json);
            request.AddHeader("Authorization", authToken);
            return await client.DeleteAsync<ServerResponse>(request, cancellationToken);
        }
    }
}
