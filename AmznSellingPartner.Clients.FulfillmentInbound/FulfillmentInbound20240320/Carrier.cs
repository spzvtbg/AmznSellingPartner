namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The carrier for the inbound shipment
	/// </summary>
	public class Carrier : BaseClass
	{
		/// <summary>
		/// The carrier code
		/// For example, USPS or DHLEX
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("alphaCode")]
		public string AlphaCode { get; set; }

		/// <summary>
		/// The name of the carrier
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
