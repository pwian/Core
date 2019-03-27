using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using StockService;

namespace iis
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateWebHostBuilder(args).Build().Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.ConfigureServices(x => x.Add(new ServiceDescriptor(typeof(IStockService), typeof(StockService.StockService), ServiceLifetime.Singleton)))
				.UseStartup<Startup>();
	}
}
