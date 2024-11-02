using System.Collections.Generic;

namespace Ellijim.Demo.CVProvider.Data
{
    public interface ICVRetrieverDataService
    {
        Dictionary<string, object> GetCV(string name);
    }
}
