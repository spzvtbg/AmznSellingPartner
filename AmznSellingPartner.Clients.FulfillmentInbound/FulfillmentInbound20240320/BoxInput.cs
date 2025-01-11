namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Input information for a given box.
	/// </summary>
	public class BoxInput : BaseClass
	{
		[JsonProperty("contentInformationSource")]
		[IsRequired]
		public BoxContentInformationSource ContentInformationSource { get; set; } 

		[JsonProperty("dimensions")]
		[IsRequired]
		public Dimensions Dimensions { get; set; } 

		/// <summary>
		/// The items and their quantity in the box. This must be empty if the box `contentInformationSource`
		/// is `BARCODE_2D` or `MANUAL_PROCESS`.
		/// </summary>
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; } 

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identica
		/// l.
		/// </summary>
		[JsonProperty("quantity")]
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		public int Quantity { get; set; } 

		[JsonProperty("weight")]
		[IsRequired]
		public Weight Weight { get; set; } 
	}
}
