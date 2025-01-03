namespace AmznSellingPartner.Clients.ProductPricing.ProductPricing20220501
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	/// <summary>
	/// The URI associated with the individual APIs that are called as part of the batch request.
	/// </summary>
	[MinLength(6)]
	[MaxLength(512)]
	public class HttpUri : StringValue
	{
	}
}
