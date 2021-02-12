using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace WFMusic
{
    class APICall
    {
        //Api Call
        private static readonly string URL = "https://localhost:44387/API/Music";

        public static async Task<string> GetALL()
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URL))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> GetById(int id)
        {
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.GetAsync(URL + "/" + id))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static async Task<string> Post(string title, string artist)
        {
            /* var inputData = new Dictionary<string, string>
             {
                 {"title", title },
                 {"artist", artist }
             };*/
            var list = new List<data>();
            list.Add(new data()
            {
                Title = title ,
                Artist = artist ,
                
            });
            var input = new FormUrlEncodedContent((IEnumerable<KeyValuePair<string, string>>)list);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(URL, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }


        public static async Task<string> PostById(int id, string title, string artist)
        {
            var inputData = new Dictionary<string, string>
            {
                {"title", title },
                {"artist", artist }
            };
            var input = new FormUrlEncodedContent(inputData);
            using (HttpClient client = new HttpClient())
            {
                using (HttpResponseMessage res = await client.PostAsync(URL + "/" + id, input))
                {
                    using (HttpContent content = res.Content)
                    {
                        string data = await content.ReadAsStringAsync();
                        if (data != null)
                        {
                            return data;
                        }
                    }
                }
            }
            return string.Empty;
        }

        public static string formatJson (string jsonstr)
        {
            JToken parseJson = JToken.Parse(jsonstr);
            return parseJson.ToString(Formatting.Indented);
        }

    }
}
