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
		[IsRequired]
		[JsonProperty("contentInformationSource")]
		public BoxContentInformationSource ContentInformationSource { get; set; }

		[IsRequired]
		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		/// <summary>
		/// The items and their quantity in the box
		/// This must be empty if the box `contentInformationSource` is `BARCODE_2D` or `MANUAL_PROCESS`
		/// </summary>
		[JsonProperty("items")]
		public List<ItemInput> Items { get; set; }

		/// <summary>
		/// Primary key to uniquely identify a Box Package
		/// PackageId must be provided if the intent is to update an existing box
		/// Adding a new box will not require providing this value
		/// Any existing PackageIds not provided will be treated as to-be-removed
		/// </summary>
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("packageId")]
		public string PackageId { get; set; }

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identical
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
