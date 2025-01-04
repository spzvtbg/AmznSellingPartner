namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The A+ Content standard fixed length list of text, usually presented as bullet points.
	/// </summary>
	public class StandardTextListBlock : BaseClass
	{
		[JsonProperty("textList")]
		[IsRequired]
		[MinItems(0)]
		[MaxItems(8)]
		public List<TextItem> TextList { get; set; } 
	}
}
