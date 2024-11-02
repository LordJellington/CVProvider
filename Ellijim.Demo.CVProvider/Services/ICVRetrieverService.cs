using System.Collections.Generic;

namespace Ellijim.Demo.CVProvider.Services
{
    public interface ICVRetrieverService
    {
        IDictionary<string, object> GetCV(string name);
    }
}
