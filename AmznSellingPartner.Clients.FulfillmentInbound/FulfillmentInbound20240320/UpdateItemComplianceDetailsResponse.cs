namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The `updateItemComplianceDetails` response.
	/// </summary>
	public class UpdateItemComplianceDetailsResponse : BaseClass
	{
		/// <summary>
		/// UUID for the given operation.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(36)]
		[MaxLength(38)]
		[JsonProperty("operationId")]
		public string OperationId { get; set; }
	}
}
