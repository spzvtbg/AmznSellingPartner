namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `updateShipmentName` request.
	/// </summary>
	public class UpdateShipmentNameRequest : BaseClass
	{
		/// <summary>
		/// A human-readable name to update the shipment name to.
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		[MinLength(1)]
		[MaxLength(100)]
		public string Name { get; set; } 
	}
}
