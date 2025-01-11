namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Contains input information about a pallet to be used in the inbound plan.
	/// </summary>
	public class PalletInput : BaseClass
	{
		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; } 

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identica
		/// l.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		public int Quantity { get; set; } 

		[JsonProperty("stackability")]
		public Stackability Stackability { get; set; } 

		[JsonProperty("weight")]
		public Weight Weight { get; set; } 
	}
}
