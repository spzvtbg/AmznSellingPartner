namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// A light-weight inbound plan.
	/// </summary>
	public class InboundPlanSummary : BaseClass
	{
		/// <summary>
		/// The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/is
		/// -8601) datetime format with pattern `yyyy-MM-ddTHH:mm:ssZ`.
		/// </summary>
		[IsRequired]
		[JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// Identifier of an inbound plan.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("inboundPlanId")]
		public string InboundPlanId { get; set; }

		/// <summary>
		/// The time at which the inbound plan was last updated. In [ISO 8601](https://developer-docs.amazon.com/sp-api/do
		/// s/iso-8601) datetime format with pattern `yyyy-MM-ddTHH:mm:ssZ`.
		/// </summary>
		[IsRequired]
		[JsonProperty("lastUpdatedAt")]
		public DateTime LastUpdatedAt { get; set; }

		/// <summary>
		/// A list of marketplace IDs.
		/// </summary>
		[IsRequired]
		[JsonProperty("marketplaceIds")]
		public List<string> MarketplaceIds { get; set; }

		/// <summary>
		/// Human-readable name of the inbound plan.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }

		[IsRequired]
		[JsonProperty("sourceAddress")]
		public Address SourceAddress { get; set; }

		/// <summary>
		/// The current status of the inbound plan. Possible values: `ACTIVE`, `VOIDED`, `SHIPPED`, `ERRORED`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
