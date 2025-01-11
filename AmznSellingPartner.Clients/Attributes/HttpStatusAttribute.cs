namespace AmznSellingPartner.Clients.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true, Inherited = true)]
    public class HttpStatusAttribute(int status) : Attribute
    {
        public int Status { get; } = status;
    }
}
