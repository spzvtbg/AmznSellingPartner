namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Standard images with text, presented one at a time. The user clicks on thumbnails to view each block
	/// .
	/// </summary>
	public class StandardMultipleImageTextModule : BaseClass
	{
		[JsonProperty("blocks")]
		public List<StandardImageTextCaptionBlock> Blocks { get; set; } 
	}
}
