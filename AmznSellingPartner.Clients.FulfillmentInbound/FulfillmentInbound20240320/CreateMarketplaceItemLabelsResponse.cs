namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `createMarketplaceItemLabels` response.
	/// </summary>
	public class CreateMarketplaceItemLabelsResponse : BaseClass
	{
		/// <summary>
		/// Resources to download the requested document.
		/// </summary>
		[JsonProperty("documentDownloads")]
		[IsRequired]
		public List<DocumentDownload> DocumentDownloads { get; set; }
	}
}
