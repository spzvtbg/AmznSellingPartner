namespace AmznSellingPartner.Clients.Replenishment.Replenishment20221107
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Use these parameters to sort the response.
	/// </summary>
	public class ListOffersRequestSort : BaseClass
	{
		/// <summary>
		/// The sort order.
		/// </summary>
		[IsRequired]
		[JsonProperty("order")]
		public SortOrder Order { get; set; }

		/// <summary>
		/// The attribute to use to sort the results.
		/// </summary>
		[IsRequired]
		[JsonProperty("key")]
		public ListOffersSortKey Key { get; set; }
	}
}
