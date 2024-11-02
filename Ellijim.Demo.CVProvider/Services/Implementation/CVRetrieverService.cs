using Ellijim.Demo.CVProvider.Data;
using System.Collections.Generic;

namespace Ellijim.Demo.CVProvider.Services.Implementation
{
    public class CVRetrieverService : ICVRetrieverService
    {
        private readonly ICVRetrieverDataService _cvRetrieverDataService;

        public CVRetrieverService(ICVRetrieverDataService cvRetrieverDataService)
        {
            _cvRetrieverDataService = cvRetrieverDataService;
        }

        public IDictionary<string, object> GetCV(string name)
        {
            return _cvRetrieverDataService.GetCV(name);
        }
    }
}
