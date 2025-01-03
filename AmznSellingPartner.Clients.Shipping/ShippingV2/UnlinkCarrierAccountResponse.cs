namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the UnlinkCarrierAccountResponse operation.
	/// </summary>
	public class UnlinkCarrierAccountResponse : BaseClass
	{
		/// <summary>
		/// Is Carrier unlinked from Merchant
		/// </summary>
		[JsonProperty("isUnlinked")]
		public bool IsUnlinked { get; set; }
	}
}
