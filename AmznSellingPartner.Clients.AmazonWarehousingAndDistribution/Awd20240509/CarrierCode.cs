namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using Newtonsoft.Json;

	/// <summary>
	/// Identifies the carrier that will deliver the shipment.
	/// </summary>
	public class CarrierCode : BaseClass
	{
		/// <summary>
		/// Denotes the carrier type.
		/// </summary>
		[JsonProperty("carrierCodeType")]
		public CarrierCodeType CarrierCodeType { get; set; }

		/// <summary>
		/// Value of the carrier code.
		/// </summary>
		[JsonProperty("carrierCodeValue")]
		public string CarrierCodeValue { get; set; }
	}
}
