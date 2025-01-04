namespace AmznSellingPartner.Clients.DataKiosk.DataKiosk20231115
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The response for the `createQuery` operation.
	/// </summary>
	public class CreateQueryResponse : BaseClass
	{
		/// <summary>
		/// The identifier for the query. This identifier is unique only in combination with a selling partner account
		/// ID.
		/// </summary>
		[JsonProperty("queryId")]
		[IsRequired]
		public string QueryId { get; set; }
	}
}
