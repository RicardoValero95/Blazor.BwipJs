using System;
using System.ComponentModel;
using System.Reflection;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Blazor.BwipJs
{
    class EnumDescriptionConverter<T> : JsonConverter<T> where T : Enum
    {
        public override T Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            string jsonValue = reader.GetString();
            foreach (FieldInfo fieldInfo in typeToConvert.GetFields())
            {
                DescriptionAttribute description = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute), false);
                if (description != null)
                {
                    if (description.Description == jsonValue)
                    {
                        return (T)fieldInfo.GetValue(null);
                    }
                }
            }
            throw new JsonException($"string {jsonValue} was not found as a description in the enum {typeToConvert}");
        }

        public override void Write(Utf8JsonWriter writer, T value, JsonSerializerOptions options)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());
            DescriptionAttribute description = (DescriptionAttribute)fieldInfo.GetCustomAttribute(typeof(DescriptionAttribute), false);
            writer.WriteStringValue(description?.Description);
        }
    }
}
