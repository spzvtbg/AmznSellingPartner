namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Details related to any dangerous goods/items that are being shipped.
	/// </summary>
	public class DangerousGoodsDetails : BaseClass
	{
		/// <summary>
		/// The specific UNID of the item being shipped.
		/// </summary>
		[JsonProperty("unitedNationsRegulatoryId")]
		[Pattern("^[0-9]{4}")]
		public string UnitedNationsRegulatoryId { get; set; } 

		/// <summary>
		/// The specific regulatory class  of the item being shipped.
		/// </summary>
		[JsonProperty("transportationRegulatoryClass")]
		[Pattern("^[1-9](\\.[1-9])?")]
		public string TransportationRegulatoryClass { get; set; } 

		/// <summary>
		/// The specific packaging group of the item being shipped.
		/// </summary>
		[JsonProperty("packingGroup")]
		public PackingGroup PackingGroup { get; set; } 

		/// <summary>
		/// The specific packing instruction of the item being shipped.
		/// </summary>
		[JsonProperty("packingInstruction")]
		public PackingInstruction PackingInstruction { get; set; } 
	}
}
