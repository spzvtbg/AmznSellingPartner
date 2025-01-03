namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class PostContentDocumentRequest : BaseClass
	{
		[IsRequired]
		[JsonProperty("contentDocument")]
		public ContentDocument ContentDocument { get; set; }
	}
}
