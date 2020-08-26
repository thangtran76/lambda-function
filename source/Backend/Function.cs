using Amazon.Lambda.APIGatewayEvents;
using Amazon.Lambda.Core;
using System.Collections.Generic;
using System.Net;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace Backend
{
    public class Function
    {
        /// <summary>
        /// Default constructor that Lambda will invoke.
        /// </summary>
        public Function()
        {
        }


        /// <summary>
        /// A Lambda function to respond to HTTP Get methods from API Gateway
        /// </summary>
        /// <param name="request"></param>
        /// <returns>The API Gateway response.</returns>
        public APIGatewayProxyResponse Welcome(APIGatewayProxyRequest request, ILambdaContext context)
        {
            context.Logger.LogLine("Say Welcome to AWS Lambda\n");

            var response = new APIGatewayProxyResponse
            {
                StatusCode = (int)HttpStatusCode.OK,
                Body = "Welcome to AWS Lambda",
                Headers = new Dictionary<string, string> { { "Content-Type", "text/plain" } }
            };

            return response;
        }
    }
}
