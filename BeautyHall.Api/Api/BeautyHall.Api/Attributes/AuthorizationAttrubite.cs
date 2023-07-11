using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BeautyHall.Models.Common.Interfaces;
using Microsoft.Extensions.Options;
using BeautyHall.Models.Common;
using Microsoft.VisualBasic;

namespace BeautyHall.Commons.Api.Attributes
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, AllowMultiple = true, Inherited = true)]

    public class AuthorizationAttribute : ActionFilterAttribute, IAsyncActionFilter
    {
        public async override Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await next();
            return;
        }
    }
}
