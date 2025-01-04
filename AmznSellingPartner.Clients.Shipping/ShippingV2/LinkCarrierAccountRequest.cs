namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for verify and add the merchant's account with a certain carrier.
	/// </summary>
	public class LinkCarrierAccountRequest : BaseClass
	{
		[JsonProperty("clientReferenceDetails")]
		public ClientReferenceDetails ClientReferenceDetails { get; set; }

		[JsonProperty("carrierAccountType")]
		[IsRequired]
		public CarrierAccountType CarrierAccountType { get; set; }

		[JsonProperty("carrierAccountAttributes")]
		[IsRequired]
		public CarrierAccountAttributes CarrierAccountAttributes { get; set; }

		[JsonProperty("encryptedCarrierAccountAttributes")]
		public CarrierAccountAttributes EncryptedCarrierAccountAttributes { get; set; }
	}
}
