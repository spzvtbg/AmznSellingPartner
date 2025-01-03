namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Contains information pertaining to the placement of the contents of an inbound plan and the related
	/// costs.
	/// </summary>
	public class PlacementOption : BaseClass
	{
		/// <summary>
		/// Discount for the offered option.
		/// </summary>
		[IsRequired]
		[JsonProperty("discounts")]
		public List<Incentive> Discounts { get; set; }

		/// <summary>
		/// The expiration date of the placement option. In [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// datetime format with pattern `yyyy-MM-ddTHH:mm:ss.sssZ`.
		/// </summary>
		[JsonProperty("expiration")]
		public DateTime Expiration { get; set; }

		/// <summary>
		/// The fee for the offered option.
		/// </summary>
		[IsRequired]
		[JsonProperty("fees")]
		public List<Incentive> Fees { get; set; }

		/// <summary>
		/// The identifier of a placement option. A placement option represents the shipment splits and destinations
		/// of SKUs.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("placementOptionId")]
		public string PlacementOptionId { get; set; }

		/// <summary>
		/// Shipment ids.
		/// </summary>
		[IsRequired]
		[JsonProperty("shipmentIds")]
		public List<string> ShipmentIds { get; set; }

		/// <summary>
		/// The status of a placement option. Possible values: `OFFERED`, `ACCEPTED`, `EXPIRED`.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("status")]
		public string Status { get; set; }
	}
}
