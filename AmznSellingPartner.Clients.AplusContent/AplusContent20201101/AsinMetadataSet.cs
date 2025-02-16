namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// The set of ASIN metadata.
    /// </summary>
    [UniqueItems]
    public class AsinMetadataSet : List<AsinMetadata>
    {
    }
}
