using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System.Net;

namespace VaporApp.Infrastructure.Filters
{
    public class GlobalExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            //Executed when an exception is not controlled
            var validation = new
            {
                Status = 500,
                Title = "An exception has occurred",
                Detail = context.Exception.Message
            };

            context.Result = new ObjectResult(validation);
            context.HttpContext.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
            context.ExceptionHandled = true;
        }
    }
}
