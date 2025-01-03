namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The JSON schema to use to provide additional inputs when required to purchase a shipping offering
	/// </summary>
	public class GetAdditionalInputsResult : BaseClass
	{
		[JsonProperty("AdditionalValue")]
		public object AdditionalValue { get; set; }
	}
}
