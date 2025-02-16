namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// The set of content badges.
    /// </summary>
    [UniqueItems]
    public class ContentBadgeSet : List<ContentBadge>
    {
    }
}
