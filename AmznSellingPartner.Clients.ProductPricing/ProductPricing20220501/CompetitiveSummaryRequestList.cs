namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// A batched list of `competitiveSummary` requests.
    /// </summary>
    [MinItems(1)]
    [MaxItems(20)]
    public class CompetitiveSummaryRequestList : List<CompetitiveSummaryRequest>
    {
    }
}
