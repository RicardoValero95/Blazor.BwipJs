using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blazor.BwipJs
{
    class EnumNameReplaceDashConverter<T> : JsonConverter<T> where T : Enum
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
            => (T)Enum.Parse(typeof(T), reader.GetString().Replace('-', '_'));

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
            => writer.WriteStringValue(value.ToString().Replace('_', '-'));
    }
}
