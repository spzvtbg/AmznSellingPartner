namespace AmznSellingPartner.Clients.HttpAttributes
{
    using System;
    using System.Net.Http;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public abstract class HttpMethodAttribute(string path, HttpMethod method) : Attribute
    {
        public string Path { get; } = path;

        public HttpMethod Method { get; } = method;
    }
}
