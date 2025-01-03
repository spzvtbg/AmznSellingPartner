namespace AmznSellingPartner.Clients.Attributes
{
    public class HttpMethodAttribute(string path) : AmznAttribute
    {
        public string Path { get; } = path;
    }

    public class HttpGetAttribute(string path) : HttpMethodAttribute(path)
    {
    }

    public class HttpDeleteAttribute(string path) : HttpMethodAttribute(path)
    {
    }

    public class HttpPatchAttribute(string path) : HttpMethodAttribute(path)
    {
    }

    public class HttpPostAttribute(string path) : HttpMethodAttribute(path)
    {
    }

    public class HttpPutAttribute(string path) : HttpMethodAttribute(path)
    {
    }
}
