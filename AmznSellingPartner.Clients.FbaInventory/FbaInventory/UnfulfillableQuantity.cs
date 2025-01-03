namespace AmznSellingPartner.Clients.FbaInventory.FbaInventory
{
	using Newtonsoft.Json;

	/// <summary>
	/// The quantity of unfulfillable inventory.
	/// </summary>
	public class UnfulfillableQuantity : BaseClass
	{
		/// <summary>
		/// The total number of units in Amazon's fulfillment network in unsellable condition.
		/// </summary>
		[JsonProperty("totalUnfulfillableQuantity")]
		public int TotalUnfulfillableQuantity { get; set; }

		/// <summary>
		/// The number of units in customer damaged disposition.
		/// </summary>
		[JsonProperty("customerDamagedQuantity")]
		public int CustomerDamagedQuantity { get; set; }

		/// <summary>
		/// The number of units in warehouse damaged disposition.
		/// </summary>
		[JsonProperty("warehouseDamagedQuantity")]
		public int WarehouseDamagedQuantity { get; set; }

		/// <summary>
		/// The number of units in distributor damaged disposition.
		/// </summary>
		[JsonProperty("distributorDamagedQuantity")]
		public int DistributorDamagedQuantity { get; set; }

		/// <summary>
		/// The number of units in carrier damaged disposition.
		/// </summary>
		[JsonProperty("carrierDamagedQuantity")]
		public int CarrierDamagedQuantity { get; set; }

		/// <summary>
		/// The number of units in defective disposition.
		/// </summary>
		[JsonProperty("defectiveQuantity")]
		public int DefectiveQuantity { get; set; }

		/// <summary>
		/// The number of units in expired disposition.
		/// </summary>
		[JsonProperty("expiredQuantity")]
		public int ExpiredQuantity { get; set; }
	}
}
