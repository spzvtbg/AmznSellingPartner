namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class PostContentDocumentResponse : BaseClass
	{
		[IsRequired]
		[JsonProperty("contentReferenceKey")]
		public ContentReferenceKey ContentReferenceKey { get; set; }
	}
}
