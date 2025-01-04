namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request body schema for the `patchListingsItem` operation.
	/// </summary>
	public class ListingsItemPatchRequest : BaseClass
	{
		/// <summary>
		/// The Amazon product type of the listings item.
		/// </summary>
		[JsonProperty("productType")]
		[IsRequired]
		public string ProductType { get; set; }

		/// <summary>
		/// One or more JSON Patch operations to perform on the listings item.
		/// </summary>
		[JsonProperty("patches")]
		[IsRequired]
		[MinItems(1)]
		public List<PatchOperation> Patches { get; set; }
	}
}
