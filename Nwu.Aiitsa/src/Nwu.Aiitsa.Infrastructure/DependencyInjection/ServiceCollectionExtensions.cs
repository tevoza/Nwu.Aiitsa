namespace Nwu.Aiitsa.Infrastructure.DependencyInjection;

using Hangfire;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

public static class ServiceCollectionExtensions
{
	public static void AddHangfireJobManagement(
		this IServiceCollection services,
		IConfiguration configuration
	)
	{
		services.AddHangfire(
			cfg =>
				cfg.SetDataCompatibilityLevel(CompatibilityLevel.Version_180)
					.UseSimpleAssemblyNameTypeSerializer()
					.UseRecommendedSerializerSettings()
					.UseSqlServerStorage(configuration.GetConnectionString("HangfireConnection"))
		);

		services.AddHangfireServer();
	}
}
