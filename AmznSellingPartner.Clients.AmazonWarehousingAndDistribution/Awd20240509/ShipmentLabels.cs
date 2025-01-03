namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Shipment labels
	/// </summary>
	public class ShipmentLabels : BaseClass
	{
		/// <summary>
		/// URL to download generated labels
		/// </summary>
		[JsonProperty("labelDownloadURL")]
		public string LabelDownloadURL { get; set; }

		/// <summary>
		/// Status of label generation
		/// </summary>
		[IsRequired]
		[JsonProperty("labelStatus")]
		public LabelStatus LabelStatus { get; set; }
	}
}
