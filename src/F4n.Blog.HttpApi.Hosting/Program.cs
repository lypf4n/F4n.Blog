﻿using System;
using System.Threading.Tasks;
using F4n.Blog.ToolKits.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace F4n.Blog.Web
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            await Host.CreateDefaultBuilder(args)
                        .UseLog4Net()
                        .ConfigureWebHostDefaults(builder =>
                        {
                            builder.UseIISIntegration()
                                    .UseStartup<Startup>();
                        }).UseAutofac().Build().RunAsync();
        }
    }
}
