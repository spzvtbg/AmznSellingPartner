namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The shipping configurations supported for the packing option. Available modes are ground small parcel,
	/// freight less-than-truckload (LTL), freight full-truckload (FTL) palletized, freight FTL non-palletized,
	/// ocean less-than-container-load (LCL), ocean full-container load (FCL), air small parcel, and air small
	/// parcel express.
	/// </summary>
	public class ShippingConfiguration : BaseClass
	{
		/// <summary>
		/// Mode of shipment transportation that this option will provide.  Possible values: `GROUND_SMALL_PARCEL`,
		/// `FREIGHT_LTL`, `FREIGHT_FTL_PALLET`, `FREIGHT_FTL_NONPALLET`, `OCEAN_LCL`, `OCEAN_FCL`, `AIR_SMALL_PARCEL`,
		/// `AIR_SMALL_PARCEL_EXPRESS`.
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("shippingMode")]
		public string ShippingMode { get; set; }

		/// <summary>
		/// Shipping program for the option. Possible values: `AMAZON_PARTNERED_CARRIER`, `USE_YOUR_OWN_CARRIER`
		/// .
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("shippingSolution")]
		public string ShippingSolution { get; set; }
	}
}
