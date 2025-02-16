namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// A set of content reference keys.
    /// </summary>
    [UniqueItems]
    public class ContentReferenceKeySet : List<ContentReferenceKey>
    {
    }
}
