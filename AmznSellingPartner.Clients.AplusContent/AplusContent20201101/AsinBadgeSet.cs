namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// The set of ASIN badges.
    /// </summary>
    [UniqueItems]
    public class AsinBadgeSet : List<AsinBadge>
    {
    }
}
