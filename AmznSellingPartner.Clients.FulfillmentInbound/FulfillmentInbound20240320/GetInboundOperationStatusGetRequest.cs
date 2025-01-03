namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/inbound/fba/2024-03-20/operations/{operationId}")]
	public class GetInboundOperationStatusGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// Identifier of an asynchronous operation.
		/// </summary>
		[InPath("operationId")]
		[IsRequired]
		[MinLength(36)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		[JsonProperty("operationId")]
		public string OperationId { get; set; }
	}
}
