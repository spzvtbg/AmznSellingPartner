namespace AmznSellingPartner.Clients.Attributes
{
    using System;
    using System.ComponentModel.DataAnnotations;

    [AttributeUsage(AttributeTargets.All, AllowMultiple = false, Inherited = true)]
    public class AmznAttribute : ValidationAttribute
    {
    }
}
