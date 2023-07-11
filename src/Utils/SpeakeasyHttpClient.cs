
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
    using System.Net.Http;
    using System.Threading.Tasks;

    public class SpeakeasyHttpClient
    {
        public HttpClient Client { get; private set; }
        private Dictionary<string, List<string>> _headers { get; } = new Dictionary<string, List<string>>();

        internal SpeakeasyHttpClient(HttpClient client)
        {
            if(client == null)
            {
                client = new HttpClient();
            }
            Client = client;
        }

        public void SetBaseUrl(string url)
        {
            Client.BaseAddress = new Uri(url);
        }

        public void AddHeader(string key, string value)
        {
            if(!_headers.ContainsKey(key))
            {
                _headers.Add(key, new List<string>());
            }
            _headers[key].Add(value);
        }

        public async Task<HttpResponseMessage> SendAsync(HttpRequestMessage message)
        {
            foreach(var h in _headers)
            {
                message.Headers.Add(h.Key, h.Value);
            }

            return await Client.SendAsync(message);
        }
    }
}