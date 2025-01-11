namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Details needed to generate the transportation options.
	/// </summary>
	public class ShipmentTransportationConfiguration : BaseClass
	{
		[JsonProperty("contactInformation")]
		public ContactInformation ContactInformation { get; set; } 

		[JsonProperty("freightInformation")]
		public FreightInformation FreightInformation { get; set; } 

		/// <summary>
		/// List of pallet configuration inputs.
		/// </summary>
		[JsonProperty("pallets")]
		public List<PalletInput> Pallets { get; set; } 

		/// <summary>
		/// The range of dates within which the seller intends to ship their items. This is the pick-up
		/// date or 'ready to ship' date, not an estimated delivery date.
		/// </summary>
		[JsonProperty("readyToShipWindow")]
		[IsRequired]
		public WindowInput ReadyToShipWindow { get; set; } 

		/// <summary>
		/// Identifier of a shipment. A shipment contains the boxes and units being inbounded.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string ShipmentId { get; set; } 
	}
}
