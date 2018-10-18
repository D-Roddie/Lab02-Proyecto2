using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http.Filters;
using Exceptions;
using Newtonsoft.Json;

namespace WebApi
{
    public class ExceptionFilter : ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            if (context.Exception is BusinessException)
            {
                var bex = (BusinessException) context.Exception;
                var json = JsonConvert.SerializeObject(bex);
                var response = new HttpResponseMessage(HttpStatusCode.InternalServerError)
                    {Content = new StringContent(json, Encoding.UTF8, "application/json")};
                context.Response = response;
            }
        }
    }
}