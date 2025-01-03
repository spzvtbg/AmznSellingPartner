namespace AmznSellingPartner.Clients.SupplySources.SupplySources20200701
{
	using Newtonsoft.Json;

	/// <summary>
	/// The pick up channel of a supply source
	/// </summary>
	public class PickupChannel : BaseClass
	{
		[JsonProperty("inventoryHoldPeriod")]
		public Duration InventoryHoldPeriod { get; set; }

		[JsonProperty("isSupported")]
		public bool IsSupported { get; set; }

		[JsonProperty("operationalConfiguration")]
		public OperationalConfiguration OperationalConfiguration { get; set; }

		/// <summary>
		/// The configuration for supporting in-store pickup
		/// </summary>
		[JsonProperty("inStorePickupConfiguration")]
		public InStorePickupConfiguration InStorePickupConfiguration { get; set; }

		/// <summary>
		/// The configuration for supporting curbside pickup
		/// </summary>
		[JsonProperty("curbsidePickupConfiguration")]
		public CurbsidePickupConfiguration CurbsidePickupConfiguration { get; set; }
	}
}
