
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using Newtonsoft.Json;

namespace Speakeasy.Utils
{
    internal class EnumSerializer: JsonConverter
    {
        public override bool CanConvert(Type objectType) =>
            objectType.IsEnum;

        public override bool CanRead => false;

        public override object? ReadJson(JsonReader reader, Type objectType, object? existingValue, JsonSerializer serializer) =>
            throw new NotImplementedException();

        public override void WriteJson(JsonWriter writer, object? value, JsonSerializer serializer)
        {
            if (value == null)
            {
                writer.WriteValue("null");
                return;
            }

            var isInt = false;
            var attributes = value.GetType().GetMember(value.ToString()).First().CustomAttributes;
            if(attributes.Count() == 0 || attributes.First().ConstructorArguments.Count() == 0)
            {
                isInt = true;
            }
            var parsedValue = Utilities.ToString(value);
            if(isInt)
            {
                writer.WriteValue(int.Parse(parsedValue));
                return;
            }
            writer.WriteValue(parsedValue);
        }
    }
}