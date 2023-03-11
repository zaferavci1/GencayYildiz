using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1
{
    public class Program
    {
        /*
         *  Asp.net Core özünde bir console programıdır.
         *  Asp.net Core kendi dahilinde bulunan sunucusunu burada ayağa kaldırır. Program.cs classında
         *  Program.cs içerisinde ayağa kaldırılacak hostun kuıllanacağı konfigurasyonların nereden alacağını bildirmektedir.
         *  
        */
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
