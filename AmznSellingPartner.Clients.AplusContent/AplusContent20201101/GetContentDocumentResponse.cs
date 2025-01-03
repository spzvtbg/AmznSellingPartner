namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	public class GetContentDocumentResponse : BaseClass
	{
		[IsRequired]
		[JsonProperty("contentRecord")]
		public ContentRecord ContentRecord { get; set; }
	}
}
