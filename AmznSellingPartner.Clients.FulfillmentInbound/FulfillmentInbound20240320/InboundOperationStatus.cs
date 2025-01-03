namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// GetInboundOperationStatus response.
	/// </summary>
	public class InboundOperationStatus : BaseClass
	{
		/// <summary>
		/// The name of the operation in the asynchronous API call.
		/// </summary>
		[IsRequired]
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("operation")]
		public string Operation { get; set; }

		/// <summary>
		/// The operation ID returned by the asynchronous API call.
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(36)]
		[MaxLength(38)]
		[JsonProperty("operationId")]
		public string OperationId { get; set; }

		/// <summary>
		/// The problems in the processing of the asynchronous operation.
		/// </summary>
		[IsRequired]
		[JsonProperty("operationProblems")]
		public List<OperationProblem> OperationProblems { get; set; }

		[IsRequired]
		[JsonProperty("operationStatus")]
		public OperationStatus OperationStatus { get; set; }
	}
}
