namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
    using AmznSellingPartner.Clients.ValidationAttributes;

    using System.Collections.Generic;

    /// <summary>
    /// The response list for the `competitiveSummaryBatch` operation.
    /// </summary>
    [MinItems(1)]
    [MaxItems(20)]
    public class CompetitiveSummaryResponseList : List<CompetitiveSummaryResponse>
    {
    }
}
