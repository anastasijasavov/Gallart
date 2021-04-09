using Gallart.DataAccess;
using Gallart.Entities;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;

namespace Gallart1._0
{
    public class Program
    {
        public static void Main(string[] args)
        {
           // AddPainting();
            CreateHostBuilder(args).Build().Run();
          
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        public static void AddPainting()
        {
            string path = "./wwwroot/paintings/";
            int br = path.Length;
            string[] files = Directory.GetFiles(path);
            MyDbContext context = new MyDbContext();
            foreach (string painting in files)
            {

                Painting item = new Painting
                {

                    Artist = painting.Substring(br, painting.IndexOf('-') - br),
                    Name = painting.Substring(painting.IndexOf('-') + 1, painting.LastIndexOf('.') - (painting.IndexOf('-') + 1)),
                    Path = painting,
                   // ListId = 0
                };
                context.Paintings.Add(item);
                context.SaveChanges();
            }
           

        }

    }
}
