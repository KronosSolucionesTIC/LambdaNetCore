using Amazon.Lambda.Core;
using AWSLambda2.RequestModel;
using AWSLambda2.ResponseModel;

// Assembly attribute to enable the Lambda function's JSON input to be converted into a .NET class.
[assembly: LambdaSerializer(typeof(Amazon.Lambda.Serialization.SystemTextJson.DefaultLambdaJsonSerializer))]

namespace AWSLambda2;

public class Function
{
    
    /// <summary>
    /// A simple function that takes a string and does a ToUpper
    /// </summary>
    /// <param name="input"></param>
    /// <param name="context"></param>
    /// <returns></returns>
    public async Task<ResponseSaludo> FuncionSaludo (RequestSaludo input, ILambdaContext context)
    {
        var response = new ResponseSaludo();
        try
        {
            response.ErrorCode = 200;
            response.ErrorMessage = "Primer Lambda";
        }
        catch (Exception e)
        {
            response.ErrorCode = 100;
            response.ErrorMessage = "Error interno: " + e.Message;
        }

        return response;
    } 
}
