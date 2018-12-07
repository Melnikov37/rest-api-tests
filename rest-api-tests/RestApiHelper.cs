using RestSharp;
using System.IO;


namespace rest_api_tests
{
    public static class RestApiHelper
    {
        public static RestClient client;
        public static RestRequest restRequest;
        public static string baseUrl = "http://mydomain.com";

        public static RestClient SetUrl(string endpoint)
        {
            var url = string.Format("{0}/{1}", baseUrl, endpoint);
            return client = new RestClient(url);
        }

        public static RestRequest CreateRequest()
        {
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "aplecation/json");
            return restRequest;
        }

        // http://mydomain.com/userinfomarion/userid	
        public static RestRequest CreateRequest(string userId)
        {
            var resource = userId;
            restRequest = new RestRequest(Method.GET);
            restRequest.AddHeader("Accept", "aplecation/json");
            return restRequest;
        }
        // http://mydomain.com/userinfomarion/userid/AccountInformation?account={accountNumber}
        public static RestRequest CreateRequest(string userId, long accountNumber)
        {
            var resource = userId + "/AccountInformation?account={accountNumber}";
            restRequest = new RestRequest(resource, Method.GET);
            restRequest.AddParameter("accountNumber", accountNumber, ParameterType.UrlSegment);
            restRequest.AddHeader("Accept", "aplecation/json");
            return restRequest;
        }


        public static IRestResponse GetResponse()
        {
            return client.Execute(restRequest);
        }
    }
}
