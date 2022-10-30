namespace RSL.CodeChallenge.Services
{
    public interface IApiService
    {
        T Post<T>(string baseUrl, string endpoint, object data, Constants.DataType dataType = Constants.DataType.Json, string username = "", string password = "") where T : class;
    }
}
