namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the LinkCarrierAccount operation
	/// </summary>
	public class LinkCarrierAccountResponse : BaseClass
	{
		[JsonProperty("registrationStatus")]
		public AccountStatus RegistrationStatus { get; set; }
	}
}
