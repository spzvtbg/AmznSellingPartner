namespace AmznSellingPartner.Clients.HttpAttributes
{
    using System;
    using System.Net.Http;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HttpDeleteAttribute(string path) : HttpMethodAttribute(path, HttpMethod.Delete)
    {

    }
}
