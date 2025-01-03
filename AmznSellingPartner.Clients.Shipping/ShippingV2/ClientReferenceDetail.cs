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
		[IsRequired]
		[JsonProperty("clientReferenceType")]
		public ClientReferenceType ClientReferenceType { get; set; }

		/// <summary>
		/// The Client Reference Id.
		/// </summary>
		[IsRequired]
		[JsonProperty("clientReferenceId")]
		public string ClientReferenceId { get; set; }
	}
}
