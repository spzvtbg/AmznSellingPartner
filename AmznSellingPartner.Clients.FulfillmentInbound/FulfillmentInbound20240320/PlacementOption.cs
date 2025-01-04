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
		[JsonProperty("discounts")]
		[IsRequired]
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
		[JsonProperty("fees")]
		[IsRequired]
		public List<Incentive> Fees { get; set; } 

		/// <summary>
		/// The identifier of a placement option. A placement option represents the shipment splits and destinations
		/// of SKUs.
		/// </summary>
		[JsonProperty("placementOptionId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string PlacementOptionId { get; set; } 

		/// <summary>
		/// Shipment ids.
		/// </summary>
		[JsonProperty("shipmentIds")]
		[IsRequired]
		public List<string> ShipmentIds { get; set; } 

		/// <summary>
		/// The status of a placement option. Possible values: `OFFERED`, `ACCEPTED`, `EXPIRED`.
		/// </summary>
		[JsonProperty("status")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Status { get; set; } 
	}
}
