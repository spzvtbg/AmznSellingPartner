namespace AmznSellingPartner.Clients
{
    using AmznSellingPartner.Clients.Attributes;

    using Newtonsoft.Json.Linq;

    using System.Collections.Generic;
    using System.Linq;
    using System.Net.Http;
    using System.Reflection;

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
            var property = typeof(T)
                .GetProperties()
                .FirstOrDefault(x => x.GetCustomAttributes<HttpStatusAttribute>()
                                      .Any(x => x.Status == (int)httpResponseMessage.StatusCode));
            var content = httpResponseMessage
                .Content
                .ReadAsStringAsync()
                .Result;

            jcontent[property.Name] = JObject.Parse(content);
            jcontent[nameof(Succeeded)] = httpResponseMessage.IsSuccessStatusCode;

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

            return jcontent.ToObject<T>();
        }
    }
}