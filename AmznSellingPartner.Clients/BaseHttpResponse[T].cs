namespace AmznSellingPartner.Clients
{
    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;

    public class BaseHttpResponse<T> : BaseClass where T : BaseHttpResponse<T>, new()
    {
        public BaseHttpResponse()
        {

        }

        private BaseHttpResponse(Dictionary<string, string> errors) 
            => this.ValidationErrors = errors;

        public bool Succeeded { get; set; }

        public Dictionary<string, string> ValidationErrors { get; }

        public static implicit operator BaseHttpResponse<T>(Dictionary<string, string> errors)
            => new BaseHttpResponse<T>(errors);

        public static explicit operator BaseHttpResponse<T>(HttpResponseMessage response)
            => ParseFromHttpResponseMessage(response);

        private static BaseHttpResponse<T> ParseFromHttpResponseMessage(HttpResponseMessage httpResponseMessage)
        {
            var jcontent = new JObject();

            foreach (var (key, value) in httpResponseMessage.Headers)
            {
                if (value is not null)
                {
                    jcontent[key.ToLower()] = value.FirstOrDefault();
                }
            }

            if (httpResponseMessage.Content is not null)
            {
                foreach (var (key, value) in httpResponseMessage.Content.Headers)
                {
                    if (value is not null)
                    {
                        jcontent[key.ToLower()] = value.FirstOrDefault();
                    }
                }
            }

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                var content = httpResponseMessage
                    .Content
                    .ReadAsStringAsync()
                    .Result;
                jcontent = JObject.Parse(content);
                jcontent.Add(nameof(Succeeded), true);
            }

            return jcontent.ToObject<T>();
        }
    }
}