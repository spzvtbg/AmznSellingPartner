namespace AmznSellingPartner.Clients.ProductTypeDefinitions.DefinitionsProductTypes20200901
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class Link : BaseClass
	{
		/// <summary>
		/// URI resource for the link.
		/// </summary>
		[JsonProperty("resource")]
		[IsRequired]
		public string Resource { get; set; }

		/// <summary>
		/// HTTP method for the link operation.
		/// </summary>
		[JsonProperty("verb")]
		[IsRequired]
		public Verb Verb { get; set; }
	}
}
