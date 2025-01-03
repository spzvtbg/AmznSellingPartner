namespace AmznSellingPartner.Clients.Invoices.InvoicesApiModel20240619
{
	using Newtonsoft.Json;

	/// <summary>
	/// The definition of the attribute option
	/// </summary>
	public class AttributeOption : BaseClass
	{
		/// <summary>
		/// The description of the attribute value
		/// </summary>
		[JsonProperty("description")]
		public string Description { get; set; }

		/// <summary>
		/// The possible values for the attribute option
		/// </summary>
		[JsonProperty("value")]
		public string Value { get; set; }
	}
}
