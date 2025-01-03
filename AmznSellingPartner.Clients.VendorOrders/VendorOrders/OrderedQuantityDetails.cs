namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Details of item quantity ordered
	/// </summary>
	public class OrderedQuantityDetails : BaseClass
	{
		/// <summary>
		/// The date when the line item quantity was updated by buyer
		/// Must be in ISO-8601 date/time format
		/// </summary>
		[JsonProperty("updatedDate")]
		public DateTime UpdatedDate { get; set; }

		/// <summary>
		/// Item quantity ordered
		/// </summary>
		[JsonProperty("orderedQuantity")]
		public ItemQuantity OrderedQuantity { get; set; }

		/// <summary>
		/// Item quantity ordered
		/// </summary>
		[JsonProperty("cancelledQuantity")]
		public ItemQuantity CancelledQuantity { get; set; }
	}
}
