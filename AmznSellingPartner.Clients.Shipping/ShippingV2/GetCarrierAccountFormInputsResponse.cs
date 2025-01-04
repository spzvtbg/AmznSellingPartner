namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the GetCarrierAccountFormInputsResponse operation.
	/// </summary>
	public class GetCarrierAccountFormInputsResponse : BaseClass
	{
		[JsonProperty("linkableCarriersList")]
		public LinkableCarriersList LinkableCarriersList { get; set; } 
	}
}
