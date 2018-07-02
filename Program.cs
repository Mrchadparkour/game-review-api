using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using game_review_api.DataProvider;

namespace game_review_api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DotNetEnv.Env.Load();

            // CreateWebHostBuilder(args).Build().Run();
            // GameDb.createFromJSON("games.json");
            // Console.WriteLine(GameDb.makeTableIfNone("consoles"));
            // Console.WriteLine(System.Environment.GetEnvironmentVariable("DB_CONNECT_DEV"));
            // GameDb.CreateFromJSON("games.json");
            GameDb.SearchByName("God of War 17287387382");

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
