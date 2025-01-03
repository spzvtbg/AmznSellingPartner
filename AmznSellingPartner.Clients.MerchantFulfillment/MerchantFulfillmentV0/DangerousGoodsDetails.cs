namespace AmznSellingPartner.Clients.MerchantFulfillment.MerchantFulfillmentV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details related to any dangerous goods or items that are shipped
	/// </summary>
	public class DangerousGoodsDetails : BaseClass
	{
		/// <summary>
		/// The specific UNID of the item being shipped
		/// </summary>
		[Pattern("^(UN|ID|NA)[0-9]{4}")]
		[JsonProperty("UnitedNationsRegulatoryId")]
		public string UnitedNationsRegulatoryId { get; set; }

		/// <summary>
		/// The specific regulatory class of the shipped item
		/// </summary>
		[Pattern("^[1-9](\\.[1-9])?")]
		[JsonProperty("TransportationRegulatoryClass")]
		public string TransportationRegulatoryClass { get; set; }

		/// <summary>
		/// The specific packaging group of the item being shipped
		/// </summary>
		[JsonProperty("PackingGroup")]
		public PackingGroup PackingGroup { get; set; }

		/// <summary>
		/// The specific packing instruction of the item being shipped
		/// </summary>
		[JsonProperty("PackingInstruction")]
		public PackingInstruction PackingInstruction { get; set; }
	}
}
