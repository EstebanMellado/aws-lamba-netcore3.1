using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.TestUtilities;
using B2BPolicyLambda.Api;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;
using Xunit;


namespace B2B_Policy_Lambda.Tests
{
    public class PolicyControllerTests
    {
        [Fact]
        public async Task GetPolicies()
        {
            var lambdaFunction = new LambdaEntryPoint();

            var requestStr = File.ReadAllText("./SampleRequests/PolicyController-GetPolicies.json");
            var request = JsonConvert.DeserializeObject<APIGatewayProxyRequest>(requestStr);
            var context = new TestLambdaContext();
            var response = await lambdaFunction.FunctionHandlerAsync(request, context);

            Assert.Equal(200, response.StatusCode);
            Assert.True(response.MultiValueHeaders.ContainsKey("Content-Type"));
            Assert.Equal("application/json; charset=utf-8", response.MultiValueHeaders["Content-Type"][0]);
        }
    }
}
