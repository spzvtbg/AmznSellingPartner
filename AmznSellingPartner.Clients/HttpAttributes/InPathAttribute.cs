namespace AmznSellingPartner.Clients.HttpAttributes
{
    using System;
    using System.Net.Http;
    using System.Web;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
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
}
