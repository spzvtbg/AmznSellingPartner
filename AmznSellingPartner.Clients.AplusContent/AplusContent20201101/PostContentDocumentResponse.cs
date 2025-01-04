namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class PostContentDocumentResponse : BaseClass
	{
		[JsonProperty("contentReferenceKey")]
		[IsRequired]
		public ContentReferenceKey ContentReferenceKey { get; set; } 
	}
}
