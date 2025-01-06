namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Net.Http;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ParameterAttribute(string name) : Attribute
    {
        public string Name { get; } = name;

        internal virtual void SetValue(HttpRequestMessage httpRequestMessage, object value) 
              => throw new NotImplementedException();
    }
}
