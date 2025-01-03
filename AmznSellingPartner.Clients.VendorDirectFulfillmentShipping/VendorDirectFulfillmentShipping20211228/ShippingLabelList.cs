namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Response payload with the list of shipping labels.
	/// </summary>
	public class ShippingLabelList : BaseClass
	{
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }

		/// <summary>
		/// An array containing the details of the generated shipping labels.
		/// </summary>
		[JsonProperty("shippingLabels")]
		public List<ShippingLabel> ShippingLabels { get; set; }
	}
}
