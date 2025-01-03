namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Individual JSON Patch operation for an HTTP PATCH request.
	/// </summary>
	public class PatchOperation : BaseClass
	{
		/// <summary>
		/// Type of JSON Patch operation. Supported JSON Patch operations include add, replace, and delete. Refer
		/// to [JavaScript Object Notation (JSON) Patch](https://tools.ietf.org/html/rfc6902) for more informati
		/// on.
		/// </summary>
		[IsRequired]
		[JsonProperty("op")]
		public Op Op { get; set; }

		/// <summary>
		/// JSON Pointer path of the element to patch. Refer to [JavaScript Object Notation (JSON) Patch](https://tools.ietf.org/html/rfc6902)
		/// for more information.
		/// </summary>
		[IsRequired]
		[JsonProperty("path")]
		public string Path { get; set; }

		/// <summary>
		/// JSON value to add, replace, or delete.
		/// </summary>
		[JsonProperty("value")]
		public List<Value> Value { get; set; }
	}
}
