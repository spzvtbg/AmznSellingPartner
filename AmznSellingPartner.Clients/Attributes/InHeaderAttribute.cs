namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.Net.Http;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class InHeaderAttribute(string name) : ParameterAttribute(name)
    {
        internal override void SetValue(HttpRequestMessage httpRequestMessage, object value) 
              => httpRequestMessage.Headers.Add(this.Name.ToLower(), $"{value}");
    }
}
