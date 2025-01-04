namespace AmznSellingPartner.Clients.Attributes
{
    using Newtonsoft.Json;

    using System;
    using System.Net.Http;
    using System.Web;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ParameterAttribute(string name) : Attribute
    {
        public string Name { get; } = name;

        internal virtual void SetValue(HttpRequestMessage httpRequestMessage, object value) 
              => throw new NotImplementedException();
    }

    public class InPathAttribute(string name) : ParameterAttribute(name)
    {
        internal override void SetValue(HttpRequestMessage httpRequestMessage, object value)
        {
            var pathValue = HttpUtility.UrlEncode(value?.ToString());
            var requestUri = httpRequestMessage
                .RequestUri
                .ToString()
                .Replace($"{{{this.Name}}}", pathValue);
            httpRequestMessage.RequestUri = new Uri(requestUri, UriKind.RelativeOrAbsolute);
        }
    }

    public class InQueryAttribute(string name) : ParameterAttribute(name)
    {
        internal override void SetValue(HttpRequestMessage httpRequestMessage, object value)
        {
            var jvalue = JsonConvert
                .SerializeObject(value)
                .Trim('"');
            var queryValue = HttpUtility.UrlEncode(jvalue);
            var requestUri = httpRequestMessage
                .RequestUri
                .ToString();
            requestUri += requestUri.Contains('?') 
                ? $"&{this.Name}={queryValue}" 
                : $"?{this.Name}={queryValue}";
            httpRequestMessage.RequestUri = new Uri(requestUri, UriKind.RelativeOrAbsolute);
        }
    }

    public class InBodyAttribute(string name) : ParameterAttribute(name)
    {
        internal override void SetValue(HttpRequestMessage httpRequestMessage, object value)
        {
            var jcontent = JsonConvert
                .SerializeObject(value)
                .Trim('"');
            var content = new StringContent(jcontent);
            content.Headers.ContentType.MediaType = "application/json";
            httpRequestMessage.Content = content;
        }
    }

    public class InHeaderAttribute(string name) : ParameterAttribute(name)
    {
        internal override void SetValue(HttpRequestMessage httpRequestMessage, object value) 
              => httpRequestMessage.Headers.Add(this.Name, $"{value}");
    }

    public class FromHeaderAttribute(string name) : ParameterAttribute(name)
    {
    }
}
