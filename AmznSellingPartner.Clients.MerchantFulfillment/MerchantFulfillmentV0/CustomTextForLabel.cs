namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// Custom text to print on the label. Note: Custom text is only included on labels that are in ZPL format
	/// (ZPL203). FedEx does not support `CustomTextForLabel`.
	/// </summary>
	[MaxLength(14)]
	public class CustomTextForLabel : StringValue
	{
	}
}
