namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;
	using AmznSellingPartner.Clients.Values;

	using System;

	[HttpGet("/listings/2021-08-01/items/{sellerId}")]
	public class SearchListingsItemsGetRequest : BaseHttpRequest
	{
		/// <summary>
		/// A selling partner identifier, such as a merchant account or vendor code.
		/// </summary>
		[InPath("sellerId")]
		[IsRequired]
		public string SellerId { get; set; } 

		/// <summary>
		/// A comma-delimited list of Amazon marketplace identifiers for the request.
		/// </summary>
		[InQuery("marketplaceIds")]
		[IsRequired]
		[MaxItems(1)]
		public CsvValue<string> MarketplaceIds { get; set; } 

		/// <summary>
		/// A locale that is used to localize issues. When not provided, the default language code of the first marketplace
		/// is used. Examples: "en_US", "fr_CA", "fr_FR". When a localization is not available in the specified locale,
		/// localized messages default to "en_US".
		/// </summary>
		[InQuery("issueLocale")]
		public string IssueLocale { get; set; } 

		/// <summary>
		/// A comma-delimited list of datasets that you want to include in the response. Default: `summaries`.
		/// </summary>
		[InQuery("includedData")]
		public CsvValue<IncludedData> IncludedData { get; set; } 

		/// <summary>
		/// A comma-delimited list of product identifiers that you can use to search for listings items.   **Note**:
		/// 1. This is required when you specify `identifiersType`. 2. You cannot use 'identifiers' if you specify
		/// `variationParentSku` or `packageHierarchySku`.
		/// </summary>
		[InQuery("identifiers")]
		[MaxItems(20)]
		public CsvValue<string> Identifiers { get; set; } 

		/// <summary>
		/// A type of product identifiers that you can use to search for listings items.   **Note**:  This is required
		/// when `identifiers` is provided.
		/// </summary>
		[InQuery("identifiersType")]
		public IdentifiersType IdentifiersType { get; set; } 

		/// <summary>
		/// Filters results to include listing items that are variation children of the specified SKU.   **Note**:
		/// You cannot use `variationParentSku` if you include `identifiers` or `packageHierarchySku` in your re
		/// quest.
		/// </summary>
		[InQuery("variationParentSku")]
		public string VariationParentSku { get; set; } 

		/// <summary>
		/// Filter results to include listing items that contain or are contained by the specified SKU.   **Note**:
		/// You cannot use `packageHierarchySku` if you include `identifiers` or `variationParentSku` in your re
		/// quest.
		/// </summary>
		[InQuery("packageHierarchySku")]
		public string PackageHierarchySku { get; set; } 

		/// <summary>
		/// A date-time that is used to filter listing items. The response includes listings items that were created
		/// at or after this time. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[InQuery("createdAfter")]
		public DateTime CreatedAfter { get; set; } 

		/// <summary>
		/// A date-time that is used to filter listing items. The response includes listings items that were created
		/// at or before this time. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[InQuery("createdBefore")]
		public DateTime CreatedBefore { get; set; } 

		/// <summary>
		/// A date-time that is used to filter listing items. The response includes listings items that were last
		/// updated at or after this time. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[InQuery("lastUpdatedAfter")]
		public DateTime LastUpdatedAfter { get; set; } 

		/// <summary>
		/// A date-time that is used to filter listing items. The response includes listings items that were last
		/// updated at or before this time. Values are in [ISO 8601](https://developer-docs.amazon.com/sp-api/docs/iso-8601)
		/// date-time format.
		/// </summary>
		[InQuery("lastUpdatedBefore")]
		public DateTime LastUpdatedBefore { get; set; } 

		/// <summary>
		/// Filter results to include only listing items that have issues that match one or more of the specified
		/// severity levels.
		/// </summary>
		[InQuery("withIssueSeverity")]
		public CsvValue<WithIssueSeverity> WithIssueSeverity { get; set; } 

		/// <summary>
		/// Filter results to include only listing items that have the specified status.
		/// </summary>
		[InQuery("withStatus")]
		public CsvValue<WithStatus> WithStatus { get; set; } 

		/// <summary>
		/// Filter results to include only listing items that don't contain the specified statuses.
		/// </summary>
		[InQuery("withoutStatus")]
		public CsvValue<WithoutStatus> WithoutStatus { get; set; } 

		/// <summary>
		/// An attribute by which to sort the returned listing items.
		/// </summary>
		[InQuery("sortBy")]
		public SortBy SortBy { get; set; } = SortBy.LastUpdatedDate;

		/// <summary>
		/// The order in which to sort the result items.
		/// </summary>
		[InQuery("sortOrder")]
		public SortOrder SortOrder { get; set; } = SortOrder.DESC;

		/// <summary>
		/// The number of results that you want to include on each page.
		/// </summary>
		[InQuery("pageSize")]
		[Maximum(20)]
		public int PageSize { get; set; } = 10;

		/// <summary>
		/// A token that you can use to fetch a specific page when there are multiple pages of results.
		/// </summary>
		[InQuery("pageToken")]
		public string PageToken { get; set; } 
	}
}
