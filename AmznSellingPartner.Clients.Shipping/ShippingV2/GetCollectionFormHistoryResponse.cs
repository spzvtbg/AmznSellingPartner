namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	/// <summary>
	/// The Response  for the GetCollectionFormHistoryResponse operation
	/// </summary>
	public class GetCollectionFormHistoryResponse : BaseClass
	{
		[JsonProperty("collectionFormsHistoryRecordList")]
		public CollectionFormsHistoryRecordList CollectionFormsHistoryRecordList { get; set; }

		/// <summary>
		/// Last Refereshed Date of collection
		/// </summary>
		[JsonProperty("lastRefreshedDate")]
		public string LastRefreshedDate { get; set; }
	}
}
