using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AlmeApiSdk.Models.Conversation.Converse;
using System.Net.Http;
using Newtonsoft.Json;

namespace AlmeApiSdk
{
    public class AlmeClient
    {
        private Uri hostUri;
        public AlmeClient(Uri uri)
        {
            hostUri = uri;
        }
        public async Task<ConverseResponse> ConverseAsync(ConverseRequest req)
        {
            ConverseResponse res = null;
            using (var client = new HttpClient())
            {
                client.BaseAddress = this.hostUri;
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                var content = JsonConvert.SerializeObject(req);

                // HTTP POST
                HttpResponseMessage response = await client.PostAsync("AlmeApi/api/Conversation/converse", new StringContent(content, Encoding.UTF8, "application/json"));
                if (response.IsSuccessStatusCode)
                {
                    string data = await response.Content.ReadAsStringAsync();
                    res = JsonConvert.DeserializeObject<ConverseResponse>(data);
                }
            }
            return res;
        }
    }
}
