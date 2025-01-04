namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `generatePackingOptions` response.
	/// </summary>
	public class GeneratePackingOptionsResponse : BaseClass
	{
		/// <summary>
		/// UUID for the given operation.
		/// </summary>
		[JsonProperty("operationId")]
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(36)]
		[MaxLength(38)]
		public string OperationId { get; set; }
	}
}
