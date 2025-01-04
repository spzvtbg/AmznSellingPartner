namespace AmznSellingPartner.Clients.AplusContent.AplusContent20201101
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The standard product comparison table.
	/// </summary>
	public class StandardComparisonTableModule : BaseClass
	{
		[JsonProperty("productColumns")]
		[MinItems(0)]
		[MaxItems(6)]
		public List<StandardComparisonProductBlock> ProductColumns { get; set; }

		[JsonProperty("metricRowLabels")]
		[MinItems(0)]
		[MaxItems(10)]
		public List<PlainTextItem> MetricRowLabels { get; set; }
	}
}
