namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	[HttpGet("/inbound/fba/2024-03-20/inboundPlans/{inboundPlanId}/shipments/{shipmentId}/contentUpdatePreviews")]
	public class ListShipmentContentUpdatePreviewsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// Identifier of an inbound plan
		/// </summary>
		[InPath("inboundPlanId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		[JsonProperty("inboundPlanId")]
		public string InboundPlanId { get; set; }

		/// <summary>
		/// Identifier of a shipment
		/// A shipment contains the boxes and units being inbounded
		/// </summary>
		[InPath("shipmentId")]
		[IsRequired]
		[MinLength(38)]
		[MaxLength(38)]
		[Pattern("^[a-zA-Z0-9-]*")]
		[JsonProperty("shipmentId")]
		public string ShipmentId { get; set; }

		/// <summary>
		/// The number of content update previews to return
		/// </summary>
		[InQuery("pageSize")]
		[Minimum(1)]
		[Maximum(20)]
		[JsonProperty("pageSize")]
		public int PageSize { get; set; }

		/// <summary>
		/// A token to fetch a certain page when there are multiple pages worth of results
		/// The value of this token is fetched from the `pagination` returned in the API response
		/// In the absence of the token value from the query parameter the API returns the first page of the result
		/// </summary>
		[InQuery("paginationToken")]
		[MinLength(0)]
		[MaxLength(1024)]
		[JsonProperty("paginationToken")]
		public string PaginationToken { get; set; }
	}
}
