namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A document related to a package.
	/// </summary>
	public class PackageDocument : BaseClass
	{
		[JsonProperty("type")]
		[IsRequired]
		public DocumentType Type { get; set; } 

		[JsonProperty("format")]
		[IsRequired]
		public DocumentFormat Format { get; set; } 

		[JsonProperty("contents")]
		[IsRequired]
		public Contents Contents { get; set; } 
	}
}
