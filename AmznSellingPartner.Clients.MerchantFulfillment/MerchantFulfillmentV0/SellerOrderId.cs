namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// A seller-defined order identifier
	/// </summary>
	[MaxLength(64)]
	public class SellerOrderId : StringValue
	{
	}
}
