namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// The estimated shipping cost associated with the transportation option.
	/// </summary>
	public class Quote : BaseClass
	{
		[IsRequired]
		[JsonProperty("cost")]
		public Currency Cost { get; set; }

		/// <summary>
		/// The time at which this transportation option quote expires. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime with pattern `yyyy-MM-ddTHH:mm:ss.sssZ`.
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; }

		/// <summary>
		/// Voidable until timestamp.
		/// </summary>
		[JsonProperty("voidableUntil")]
		public DateTime VoidableUntil { get; set; }
	}
}
