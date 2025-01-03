namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains information pertaining to a shipment in an inbound plan
	/// </summary>
	public class Shipment : BaseClass
	{
		/// <summary>
		/// A unique identifier created by Amazon that identifies this Amazon-partnered, Less Than Truckload/Full Truckloa
		/// (LTL/FTL) shipment
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("amazonReferenceId")]
		public string AmazonReferenceId { get; set; }

		[JsonProperty("contactInformation")]
		public ContactInformation ContactInformation { get; set; }

		[JsonProperty("dates")]
		public Dates Dates { get; set; }

		[IsRequired]
		[JsonProperty("destination")]
		public ShipmentDestination Destination { get; set; }

		[JsonProperty("freightInformation")]
		public FreightInformation FreightInformation { get; set; }

		/// <summary>
		/// The name of the shipment
		/// </summary>
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The identifier of a placement option
		/// A placement option represents the shipment splits and destinations of SKUs
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("placementOptionId")]
		public string PlacementOptionId { get; set; }

		[JsonProperty("selectedDeliveryWindow")]
		public SelectedDeliveryWindow SelectedDeliveryWindow { get; set; }

		/// <summary>
		/// Identifier of a transportation option
		/// A transportation option represent one option for how to send a shipment
		/// </summary>
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("selectedTransportationOptionId")]
		public string SelectedTransportationOptionId { get; set; }

		/// <summary>
		/// List of self ship appointment details
		/// </summary>
		[JsonProperty("selfShipAppointmentDetails")]
		public List<SelfShipAppointmentDetails> SelfShipAppointmentDetails { get; set; }

		/// <summary>
		/// The confirmed shipment ID which shows up on labels (for example, `FBA1234ABCD`)
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("shipmentConfirmationId")]
		public string ShipmentConfirmationId { get; set; }

		/// <summary>
		/// Identifier of a shipment
		/// A shipment contains the boxes and units being inbounded
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }

		[IsRequired]
		[JsonProperty("source")]
		public ShipmentSource Source { get; set; }

		/// <summary>
		/// The status of a shipment
		/// The state of the shipment will typically start as `UNCONFIRMED`, then transition to `WORKING` after a placeme
		/// t option has been confirmed, and then to `READY_TO_SHIP` once labels are generated
		/// Possible values: `ABANDONED`, `CANCELLED`, `CHECKED_IN`, `CLOSED`, `DELETED`, `DELIVERED`, `IN_TRANSIT`, `MI
		/// ED`, `READY_TO_SHIP`, `RECEIVING`, `SHIPPED`, `UNCONFIRMED`, `WORKING`
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("status")]
		public string Status { get; set; }

		[JsonProperty("trackingDetails")]
		public TrackingDetails TrackingDetails { get; set; }
	}
}
