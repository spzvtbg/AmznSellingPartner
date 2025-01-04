namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Net.Http;

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public abstract class HttpMethodAttribute(string path, HttpMethod method) : Attribute
    {
        public string Path { get; } = path;

        public HttpMethod Method { get; } = method;
    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HttpGetAttribute(string path) : HttpMethodAttribute(path, HttpMethod.Get)
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HttpDeleteAttribute(string path) : HttpMethodAttribute(path, HttpMethod.Delete)
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HttpPatchAttribute(string path) : HttpMethodAttribute(path, HttpMethod.Patch)
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HttpPostAttribute(string path) : HttpMethodAttribute(path, HttpMethod.Post)
    {

    }

    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class HttpPutAttribute(string path) : HttpMethodAttribute(path, HttpMethod.Put)
    {

    }
}
