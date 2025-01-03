namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The state or province code. This is a required field in Canada, US, and UK marketplaces, and for shipments tha
	/// originate in China.
	/// </summary>
	[MaxLength(30)]
	public class StateOrProvinceCode : StringValue
	{
	}
}
