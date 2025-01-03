namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The enforcement action taken by Amazon that affect the publishing or status of a listing
	/// </summary>
	public class IssueEnforcementAction : BaseClass
	{
		/// <summary>
		/// The enforcement action name.   Possible values:   * `LISTING_SUPPRESSED` - This enforcement takes down the cur
		/// ent listing item's buyability.   * `ATTRIBUTE_SUPPRESSED` - An attribute's value on the listing item is invali
		/// , which causes it to be rejected by Amazon.   * `CATALOG_ITEM_REMOVED` - This catalog item is inactive on Amaz
		/// n, and all offers against it in the applicable marketplace are non-buyable.   * `SEARCH_SUPPRESSED` - This val
		/// e indicates that the catalog item is hidden from search results.
		/// </summary>
		[IsRequired]
		[JsonProperty("action")]
		public string Action { get; set; }
	}
}
