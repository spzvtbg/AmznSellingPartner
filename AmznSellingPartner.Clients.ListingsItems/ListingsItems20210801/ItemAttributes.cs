namespace AmznSellingPartner.Clients.ListingsItems.ListingsItems20210801
{
	using Newtonsoft.Json;

	/// <summary>
	/// A JSON object containing structured listings item attribute data keyed by attribute name.
	/// </summary>
	public class ItemAttributes : BaseClass
	{
		[JsonProperty("")]
		public bool? AdditionalValue { get; set; }
	}
}
