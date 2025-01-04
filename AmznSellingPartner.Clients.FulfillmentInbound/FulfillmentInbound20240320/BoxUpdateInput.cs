namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Input information for updating a box
	/// </summary>
	public class BoxUpdateInput : BaseClass
	{
		[JsonProperty("contentInformationSource")]
		[IsRequired]
		public BoxContentInformationSource ContentInformationSource { get; set; } 

		[JsonProperty("dimensions")]
		[IsRequired]
		public Dimensions Dimensions { get; set; } 

		/// <summary>
		/// The items and their quantity in the box. This must be empty if the box `contentInformationSource` is
		/// `BARCODE_2D` or `MANUAL_PROCESS`.
		/// </summary>
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; } 

		/// <summary>
		/// Primary key to uniquely identify a Box Package. PackageId must be provided if the intent is to update
		/// an existing box. Adding a new box will not require providing this value. Any existing PackageIds not
		/// provided will be treated as to-be-removed
		/// </summary>
		[JsonProperty("packageId")]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		public string PackageId { get; set; } 

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identical.
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
