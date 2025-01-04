namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The transportation option selected to confirm.
	/// </summary>
	public class TransportationSelection : BaseClass
	{
		[JsonProperty("contactInformation")]
		public ContactInformation ContactInformation { get; set; }

		/// <summary>
		/// Shipment ID that the transportation Option is for.
		/// </summary>
		[JsonProperty("shipmentId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string ShipmentId { get; set; }

		/// <summary>
		/// Transportation option being selected for the provided shipment.
		/// </summary>
		[JsonProperty("transportationOptionId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string TransportationOptionId { get; set; }
	}
}
