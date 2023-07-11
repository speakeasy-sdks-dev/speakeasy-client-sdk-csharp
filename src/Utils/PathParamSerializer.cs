
//------------------------------------------------------------------------------
// <auto-generated>
// This code was generated by Speakeasy (https://speakeasyapi.dev). DO NOT EDIT.
//
// Changes to this file may cause incorrect behavior and will be lost when
// the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
namespace Speakeasy.Utils
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Newtonsoft.Json;

    internal class PathParamSerializer
    {
        public static string Serialize(string style, bool explode, object? value) =>
            value == null ? "" : style switch {
                 "simple" => SerializeSimple(explode, value),
                 _ => throw new ArgumentException($"Invalid path param serialization style [{style}]")
            };

        private static string SerializeSimple(bool explode, object value)
        {
            if(value == null || Utilities.IsString(value) || Utilities.IsPrimitive(value) || Utilities.IsEnum(value))
            {
                return Utilities.ToString(value);
            }

            if(Utilities.IsDictionary(value))
            {
                var json = JsonConvert.SerializeObject(value);
                var map = JsonConvert.DeserializeObject<Dictionary<object, object>>(json);
                var separator = explode ? "=" : ",";
                return String.Join(",", from k in map.Keys select $"{Utilities.ToString(k)}{separator}{Utilities.ToString(map[k])}");
            }

            if(Utilities.IsList(value))
            {
                var list = (IEnumerable<object>)value;
                return String.Join(",", from i in list select Utilities.ToString(i));
            }

            var props = value.GetType().GetProperties();
            var parsedProps = new List<string>();
            foreach(var prop in props)
            {
                var attr = (from c in prop.CustomAttributes
                    where c.ConstructorArguments.Count() > 0
                    select c).Last();

                var key = attr.ConstructorArguments.First().Value;
                var val = prop.GetValue(value);
                if(val == null)
                {
                    continue;
                }
                var strVal = Utilities.ToString(val);

                var separator = explode ? "=" : ",";
                parsedProps.Add($"{key}{separator}{strVal}");
            }
            return String.Join(",", parsedProps);
        }
    }
}