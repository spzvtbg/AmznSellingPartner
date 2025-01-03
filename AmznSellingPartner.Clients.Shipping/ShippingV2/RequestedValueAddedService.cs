namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A value-added service to be applied to a shipping service purchase.
	/// </summary>
	public class RequestedValueAddedService : BaseClass
	{
		/// <summary>
		/// The identifier of the selected value-added service. Must be among those returned in the response to the getRat
		/// s operation.
		/// </summary>
		[IsRequired]
		[JsonProperty("id")]
		public string Id { get; set; }
	}
}
