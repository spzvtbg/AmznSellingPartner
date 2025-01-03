namespace AmznSellingPartner.Clients.Attributes
{
    public class ParameterAttribute(string name) : AmznAttribute
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
}
