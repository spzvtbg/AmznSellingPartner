namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// Info About Linkable Account Type
	/// </summary>
	public class LinkableAccountType : BaseClass
	{
		[JsonProperty("accountType")]
		public AccountType AccountType { get; set; } 

		[JsonProperty("carrierAccountInputs")]
		public CarrierAccountInputsList CarrierAccountInputs { get; set; } 
	}
}
