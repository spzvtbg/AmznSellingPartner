namespace AmznSellingPartner.Clients.HttpAttributes
{
    using Newtonsoft.Json;

    using System;
    using System.Net.Http;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
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
}
