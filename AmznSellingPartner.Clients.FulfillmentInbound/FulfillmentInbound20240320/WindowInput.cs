namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Contains only a starting DateTime.
	/// </summary>
	public class WindowInput : BaseClass
	{
		/// <summary>
		/// The start date of the window. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601) datetime
		/// format with minute precision. Supports patterns `yyyy-MM-ddTHH:mmZ`, `yyyy-MM-ddTHH:mm:ssZ`, or `yyyy-MM-ddTHH:mm:ss.sssZ`.
		/// Note that non-zero second and millisecond components are removed.
		/// </summary>
		[JsonProperty("start")]
		[IsRequired]
		public DateTime Start { get; set; }
	}
}
