namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Client Reference Details
	/// </summary>
	public class ClientReferenceDetail : BaseClass
	{
		/// <summary>
		/// Client Reference type.
		/// </summary>
		[JsonProperty("clientReferenceType")]
		[IsRequired]
		public ClientReferenceType ClientReferenceType { get; set; }

		/// <summary>
		/// The Client Reference Id.
		/// </summary>
		[JsonProperty("clientReferenceId")]
		[IsRequired]
		public string ClientReferenceId { get; set; }
	}
}
