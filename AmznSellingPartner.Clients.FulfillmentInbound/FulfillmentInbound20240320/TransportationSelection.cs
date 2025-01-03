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
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }

		/// <summary>
		/// Transportation option being selected for the provided shipment.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("transportationOptionId")]
		public string TransportationOptionId { get; set; }
	}
}
