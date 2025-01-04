namespace AmznSellingPartner.BuildTools
{
    internal class AmznProperties : AmznUnhandled<AmznProperty>
    {
        internal void SetRequired(string proeprty)
        {
            if (this.TryGetValue($"{proeprty}", out var amznProperty))
            {
                amznProperty.IsRequired = true;
            }
        }
    }
}