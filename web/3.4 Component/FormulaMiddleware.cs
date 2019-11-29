using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;
namespace _3._4_Component
{
    public class FormulaMiddleware
    {
        readonly RequestDelegate _next;

        public FormulaMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            int x = 2;
            double result = (1 / (4 * Math.Sqrt(3))) * Math.Log((Math.Sqrt(x * x + 2) - (x * Math.Sqrt(3)) / ((Math.Sqrt(x * x + 2) + (x * Math.Sqrt(3))))));
            await context.Response.WriteAsync(result.ToString());
        }
    }
}
