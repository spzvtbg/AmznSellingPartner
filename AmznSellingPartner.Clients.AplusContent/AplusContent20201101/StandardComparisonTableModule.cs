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
		[MinItems(0)]
		[MaxItems(6)]
		[JsonProperty("productColumns")]
		public List<StandardComparisonProductBlock> ProductColumns { get; set; }

		[MinItems(0)]
		[MaxItems(10)]
		[JsonProperty("metricRowLabels")]
		public List<PlainTextItem> MetricRowLabels { get; set; }
	}
}
