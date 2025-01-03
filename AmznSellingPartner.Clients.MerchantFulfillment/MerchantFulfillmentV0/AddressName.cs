namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The name of the addressee, or business name
	/// </summary>
	[MaxLength(30)]
	public class AddressName : StringValue
	{
	}
}
