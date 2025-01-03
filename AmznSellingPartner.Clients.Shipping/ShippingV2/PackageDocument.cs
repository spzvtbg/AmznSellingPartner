namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A document related to a package.
	/// </summary>
	public class PackageDocument : BaseClass
	{
		[IsRequired]
		[JsonProperty("type")]
		public DocumentType Type { get; set; }

		[IsRequired]
		[JsonProperty("format")]
		public DocumentFormat Format { get; set; }

		[IsRequired]
		[JsonProperty("contents")]
		public Contents Contents { get; set; }
	}
}
