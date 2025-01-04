namespace AmznSellingPartner.Clients.Attributes
{
    using System;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class ParameterAttribute(string name) : Attribute
    {
        public string Name { get; } = name;
    }

    public class InPathAttribute(string name) : ParameterAttribute(name)
    {
    }

    public class InQueryAttribute(string name) : ParameterAttribute(name)
    {
    }

    public class InBodyAttribute(string name) : ParameterAttribute(name)
    {
    }

    public class InHeaderAttribute(string name) : ParameterAttribute(name)
    {
    }

    public class FromHeaderAttribute(string name) : ParameterAttribute(name)
    {
    }
}
