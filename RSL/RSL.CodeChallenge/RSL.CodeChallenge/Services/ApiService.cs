using Newtonsoft.Json;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Net;

namespace RSL.CodeChallenge.Services
{
    public class ApiService : IApiService
    {
        public T Post<T>(string baseUrl, string endpoint, object data, Constants.DataType dataType = Constants.DataType.Json, string username = "", string password = "") where T : class
        {
            try
            {
                if (string.IsNullOrEmpty(baseUrl))
                {
                    return null;
                }

                var client = new RestClient(baseUrl);
                if (!string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password))
                {
                    client.Authenticator = new HttpBasicAuthenticator(username, password);
                }

                var request = new RestRequest(endpoint, Method.Post);

                if (data != null)
                {
                    if (dataType == Constants.DataType.FormData)
                    {
                        request.AddHeader("content-type", "application/x-www-form-urlencoded");
                        request.AddParameter("application/x-www-form-urlencoded", data, ParameterType.RequestBody);
                    }
                    else
                    {
                        var jsonData = JsonConvert.SerializeObject(data);
                        request.AddJsonBody(jsonData);
                    }
                }

                var response = client.ExecutePost(request);
                if (response == null || (response.StatusCode != HttpStatusCode.OK && response.StatusCode != HttpStatusCode.Created))
                {
                    return null;
                }

                return JsonConvert.DeserializeObject<T>(response.Content);
            }
            catch (Exception ex)
            {
                // TODO: logo exception
                return null;
            }
        }
    }
}
