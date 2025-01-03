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
		[IsRequired]
		[JsonProperty("contentInformationSource")]
		public BoxContentInformationSource ContentInformationSource { get; set; }

		[IsRequired]
		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		/// <summary>
		/// The items and their quantity in the box. This must be empty if the box `contentInformationSource` is `BARCODE_
		/// D` or `MANUAL_PROCESS`.
		/// </summary>
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; }

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identical.
		/// </summary>
		[IsRequired]
		[Minimum(1)]
		[Maximum(10000)]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		[IsRequired]
		[JsonProperty("weight")]
		public Weight Weight { get; set; }
	}
}
