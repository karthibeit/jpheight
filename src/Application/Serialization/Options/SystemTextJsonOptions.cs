using System.Text.Json;
using JPBlazor.Application.Interfaces.Serialization.Options;

namespace JPBlazor.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}