namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Inbound plan containing details of the inbound workflow.
	/// </summary>
	public class InboundPlan : BaseClass
	{
		/// <summary>
		/// The time at which the inbound plan was created. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/is
		/// -8601) datetime with pattern `yyyy-MM-ddTHH:mm:ssZ`.
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

		/// <summary>
		/// Packing options for the inbound plan. This property will be populated when it has been generated via the corre
		/// ponding operation. If there is a chosen placement option, only packing options for that placement option will
		/// e returned. If there are confirmed shipments, only packing options for those shipments will be returned. Query
		/// the packing option for more details.
		/// </summary>
		[JsonProperty("packingOptions")]
		public List<PackingOptionSummary> PackingOptions { get; set; }

		/// <summary>
		/// Placement options for the inbound plan. This property will be populated when it has been generated via the cor
		/// esponding operation. If there is a chosen placement option, that will be the only returned option. Query the p
		/// acement option for more details.
		/// </summary>
		[JsonProperty("placementOptions")]
		public List<PlacementOptionSummary> PlacementOptions { get; set; }

		/// <summary>
		/// A list of shipment IDs for the inbound plan. This property is populated when it has been generated with the `c
		/// nfirmPlacementOptions` operation. Only shipments from the chosen placement option are returned. Query the ship
		/// ent for more details.
		/// </summary>
		[JsonProperty("shipments")]
		public List<ShipmentSummary> Shipments { get; set; }

		[IsRequired]
		[JsonProperty("sourceAddress")]
		public Address SourceAddress { get; set; }

		/// <summary>
		/// Current status of the inbound plan. Possible values: `ACTIVE`, `VOIDED`, `SHIPPED`, `ERRORED`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
