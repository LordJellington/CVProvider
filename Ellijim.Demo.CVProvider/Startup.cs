using Ellijim.Demo.CVProvider.Data;
using Ellijim.Demo.CVProvider.Data.Implementation;
using Ellijim.Demo.CVProvider.Services;
using Ellijim.Demo.CVProvider.Services.Implementation;
using Microsoft.Azure.Functions.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection;

[assembly: FunctionsStartup(typeof(Ellijim.Demo.CVProvider.Startup))]

namespace Ellijim.Demo.CVProvider
{
    public class Startup : FunctionsStartup
    {
        public override void Configure(IFunctionsHostBuilder builder)
        {
            builder.Services.AddSingleton<ICVRetrieverService, CVRetrieverService>();
            builder.Services.AddSingleton<ICVRetrieverDataService, CVRetrieverDataService>();
        }
    }
}
