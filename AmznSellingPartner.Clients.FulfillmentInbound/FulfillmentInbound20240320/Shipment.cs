namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains information pertaining to a shipment in an inbound plan.
	/// </summary>
	public class Shipment : BaseClass
	{
		/// <summary>
		/// A unique identifier created by Amazon that identifies this Amazon-partnered, Less Than Truckload/Full
		/// Truckload (LTL/FTL) shipment.
		/// </summary>
		[JsonProperty("amazonReferenceId")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string AmazonReferenceId { get; set; } 

		[JsonProperty("contactInformation")]
		public ContactInformation ContactInformation { get; set; } 

		[JsonProperty("dates")]
		public Dates Dates { get; set; } 

		[JsonProperty("destination")]
		[IsRequired]
		public ShipmentDestination Destination { get; set; } 

		[JsonProperty("freightInformation")]
		public FreightInformation FreightInformation { get; set; } 

		/// <summary>
		/// The name of the shipment.
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; } 

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

		[JsonProperty("selectedDeliveryWindow")]
		public SelectedDeliveryWindow SelectedDeliveryWindow { get; set; } 

		/// <summary>
		/// Identifier of a transportation option. A transportation option represent one option for how to send a
		/// shipment.
		/// </summary>
		[JsonProperty("selectedTransportationOptionId")]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string SelectedTransportationOptionId { get; set; } 

		/// <summary>
		/// List of self ship appointment details.
		/// </summary>
		[JsonProperty("selfShipAppointmentDetails")]
		public List<SelfShipAppointmentDetails> SelfShipAppointmentDetails { get; set; } 

		/// <summary>
		/// The confirmed shipment ID which shows up on labels (for example, `FBA1234ABCD`).
		/// </summary>
		[JsonProperty("shipmentConfirmationId")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string ShipmentConfirmationId { get; set; } 

		/// <summary>
		/// Identifier of a shipment. A shipment contains the boxes and units being inbounded.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string ShipmentId { get; set; } 

		[JsonProperty("source")]
		[IsRequired]
		public ShipmentSource Source { get; set; } 

		/// <summary>
		/// The status of a shipment. The state of the shipment will typically start as `UNCONFIRMED`, then transition
		/// to `WORKING` after a placement option has been confirmed, and then to `READY_TO_SHIP` once labels are
		/// generated.  Possible values: `ABANDONED`, `CANCELLED`, `CHECKED_IN`, `CLOSED`, `DELETED`, `DELIVERED`,
		/// `IN_TRANSIT`, `MIXED`, `READY_TO_SHIP`, `RECEIVING`, `SHIPPED`, `UNCONFIRMED`, `WORKING`
		/// </summary>
		[JsonProperty("status")]
		[MinLength(1)]
		[MaxLength(1024)]
		public string Status { get; set; } 

		[JsonProperty("trackingDetails")]
		public TrackingDetails TrackingDetails { get; set; } 
	}
}
