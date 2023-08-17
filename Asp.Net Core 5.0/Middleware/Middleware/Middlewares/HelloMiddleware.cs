using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace Middleware.Middlewares
{
    public class HelloMiddleware
    {
        RequestDelegate _next;
        public HelloMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public async Task Invoke(HttpContext context)
        {
            //Custom operasyon...

            Console.WriteLine("HELLO");
            await _next.Invoke(context);//kısa devre olmasın devam etsin.
            Console.Out.WriteLineAsync("Good Bye");

        }
    }
}
