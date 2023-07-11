
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
    using System.Linq;
    using System.Collections.Generic;
    using System.Text.RegularExpressions;
    using Newtonsoft.Json;
    using NodaTime;

    public class Utilities
    {
        public static bool IsDictionary(object obj) =>
            obj != null && obj.GetType().GetInterface(typeof(IDictionary<,>).Name) != null;

        public static bool IsList(object obj) =>
            (!Utilities.IsDictionary(obj) && !Utilities.IsString(obj) && obj.GetType().GetInterface(typeof(IEnumerable<>).Name) != null);

        public static bool IsString(object obj) =>
            obj != null && obj.GetType().IsAssignableTo(typeof(string));

        public static bool IsPrimitive(object obj) =>
            obj != null && obj.GetType().IsPrimitive;

        public static bool IsEnum(object obj) =>
            obj != null && obj.GetType().IsEnum;

        public static bool IsDate(object obj) =>
            obj != null && (obj.GetType() == typeof(DateTime) || obj.GetType() == typeof(LocalDate));

        private static string StripSurroundingQuotes(string input)
        {
            Regex surroundingQuotesRegex = new Regex("^\"(.*)\"$");
            var match = surroundingQuotesRegex.Match(input);
            if(match.Groups.Values.Count() == 2)
            {
                return match.Groups.Values.Last().ToString();
            }
            return input;
        }

        public static string ToString(object obj)
        {
            if(obj == null)
            {
                return null;
            }

            if(IsString(obj))
            {
                return obj.ToString();
            }

            if(IsPrimitive(obj))
            {
                return JsonConvert.SerializeObject(obj);
            }

            if(IsEnum(obj))
            {
                var attributes = obj.GetType().GetMember(obj.ToString()).First().CustomAttributes;
                if(attributes.Count() == 0)
                {
                    return JsonConvert.SerializeObject(obj);
                }

                var args = attributes.First().ConstructorArguments;
                if(args.Count() == 0)
                {
                    return JsonConvert.SerializeObject(obj);
                }
                return StripSurroundingQuotes(args.First().ToString());
            }

            if(IsDate(obj))
            {
                return StripSurroundingQuotes(JsonConvert.SerializeObject(obj, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }}));
            }
            return JsonConvert.SerializeObject(obj, new JsonSerializerSettings(){ NullValueHandling = NullValueHandling.Ignore, Converters = new JsonConverter[] { new IsoDateTimeSerializer(), new EnumSerializer() }});
        }

        public static bool IsContentTypeMatch(string expected, string actual)
        {
            if(expected == actual || expected == "*" || expected == "*/*")
            {
                return true;
            }

            var expectedSubs = expected.Split('/');
            var actualSubs = actual.Split('/');

            var expectedMediaType = expectedSubs[0];
            var expectedEncoding = expectedSubs[1];
            var actualMediaType = actualSubs[0];
            var actualEncoding = actualSubs[1];

            if(expectedMediaType == "*" && expectedEncoding == actualEncoding)
            {
                return true;
            }

            if(expectedMediaType != actualMediaType)
            {
                return false;
            }

            if(expectedEncoding == "*" || expectedEncoding == actualEncoding)
            {
                return true;
            }
            return false;
        }

        public static string PrefixBearer(string authHeaderValue)
        {
            if(authHeaderValue.StartsWith("bearer ", StringComparison.InvariantCultureIgnoreCase))
            {
                return authHeaderValue;
            }

            return $"Bearer {authHeaderValue}";
        }
    }
}