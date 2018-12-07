using NUnit.Framework;
using TechTalk.SpecFlow;

namespace rest_api_tests.Steps
{
    [Binding]
    public sealed class StepDefinition1
    {
        [Given(@"I have a endpoint (.*)")]
        public void GivenIHaveAEndpointEndpoint(string endpoint)
        {
            RestApiHelper.SetUrl(endpoint);
        }

        [When(@"I call get method of api")]
        public void WhenICallGetMethodOfApi()
        {
            RestApiHelper.CreateRequest();
        }

        [Then(@"I get API response in json format")]
        public void ThenIGetAPIResponseInJsonFormat()
        {
            var expected = "something";
            var apiResponse = RestApiHelper.GetResponse();
            if(apiResponse.StatusCode == System.Net.HttpStatusCode.OK)
            {
                Assert.That(apiResponse.Content, Is.EqualTo(expected), "Eroro Message");
            }
        }

        [When(@"I call get method of get user information using (.*)")]
        public void WhenICallGetMethodOfGetUserInformationUsingUser(string userId)
        {
            RestApiHelper.CreateRequest(userId);
        }

        [When(@"I call get method of get user account information using (.*) and (.*)")]
        public void WhenICallGetMethodOfGetUserInformationUsingUserAnd(string userId, long accountNumber )
        {
            RestApiHelper.CreateRequest(userId, accountNumber);
        }


        [Then(@"I will get user information")]
        public void ThenIWillGetUserInformation()
        {
            var response = RestApiHelper.GetResponse();
        }

    }
}
