using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _3._5_Error_Auth
{
    public class TokenMiddleware
    {
        private readonly RequestDelegate _next;

        public TokenMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            var token = context.Request.Query["token"];
            if (token != "0123")
            {
                context.Response.StatusCode = 403;
                await context.Response.WriteAsync("Token is invalid");
            }
            else
            {
                await _next.Invoke(context);
            }
        }
    }
}
