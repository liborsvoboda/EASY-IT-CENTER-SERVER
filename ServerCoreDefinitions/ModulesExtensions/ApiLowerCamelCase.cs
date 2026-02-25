using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace EasyITCenter.ServerCoreStructure {

    public class LowercaseContractResolver : DefaultContractResolver {
        protected override string ResolvePropertyName(string propertyName) {
            return propertyName.ToLower();
        }
    }

    /*
    Usage:

    
    var settings = new JsonSerializerSettings();
    settings.ContractResolver = new LowercaseContractResolver();
    var json = JsonConvert.SerializeObject(data, Formatting.Indented, settings);
    Wil result in:

    Result:
    {"username":"Mark","apitoken":"xyzABC1234"}
}