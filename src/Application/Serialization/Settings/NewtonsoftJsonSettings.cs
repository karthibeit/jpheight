
using JPBlazor.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace JPBlazor.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}