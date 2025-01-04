namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema Call to generate the collection form.
	/// </summary>
	public class GenerateCollectionFormRequest : BaseClass
	{
		[JsonProperty("clientReferenceDetails")]
		public ClientReferenceDetails ClientReferenceDetails { get; set; }

		[JsonProperty("carrierId")]
		[IsRequired]
		public CarrierId CarrierId { get; set; }

		[JsonProperty("shipFromAddress")]
		public Address ShipFromAddress { get; set; }
	}
}
