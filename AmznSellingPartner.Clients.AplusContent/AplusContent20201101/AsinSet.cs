namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// The set of ASINs.
    /// </summary>
    [UniqueItems]
    public class AsinSet : List<Asin>
    {
    }
}
