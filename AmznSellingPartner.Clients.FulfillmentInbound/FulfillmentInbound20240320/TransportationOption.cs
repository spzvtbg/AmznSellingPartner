namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains information pertaining to a transportation option and the related carrier.
	/// </summary>
	public class TransportationOption : BaseClass
	{
		[JsonProperty("carrier")]
		[IsRequired]
		public Carrier Carrier { get; set; }

		[JsonProperty("carrierAppointment")]
		public CarrierAppointment CarrierAppointment { get; set; }

		/// <summary>
		/// Identifies a list of preconditions for confirming the transportation option.
		/// </summary>
		[JsonProperty("preconditions")]
		[IsRequired]
		public List<string> Preconditions { get; set; }

		[JsonProperty("quote")]
		public Quote Quote { get; set; }

		/// <summary>
		/// Identifier of a shipment. A shipment contains the boxes and units being inbounded.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string ShipmentId { get; set; }

		/// <summary>
		/// Mode of shipment transportation that this option will provide.  Possible values: `GROUND_SMALL_PARCEL`,
		/// `FREIGHT_LTL`, `FREIGHT_FTL_PALLET`, `FREIGHT_FTL_NONPALLET`, `OCEAN_LCL`, `OCEAN_FCL`, `AIR_SMALL_PARCEL`,
		/// `AIR_SMALL_PARCEL_EXPRESS`.
		/// </summary>
		[JsonProperty("shippingMode")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string ShippingMode { get; set; }

		/// <summary>
		/// Shipping program for the option. Possible values: `AMAZON_PARTNERED_CARRIER`, `USE_YOUR_OWN_CARRIER`
		/// .
		/// </summary>
		[JsonProperty("shippingSolution")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		public string ShippingSolution { get; set; }

		/// <summary>
		/// Identifier of a transportation option. A transportation option represent one option for how to send a
		/// shipment.
		/// </summary>
		[JsonProperty("transportationOptionId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string TransportationOptionId { get; set; }
	}
}
