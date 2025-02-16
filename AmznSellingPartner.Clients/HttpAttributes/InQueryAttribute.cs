namespace AmznSellingPartner.Clients.HttpAttributes
{
    using Newtonsoft.Json;

    using System;
    using System.Net.Http;
    using System.Web;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
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
}
