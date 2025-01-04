namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// UnmanifestedShipmentLocation info
	/// </summary>
	public class UnmanifestedShipmentLocation : BaseClass
	{
		[JsonProperty("address")]
		public Address Address { get; set; } 

		/// <summary>
		/// Its Last Manifest Date.
		/// </summary>
		[JsonProperty("lastManifestDate")]
		public DateTime LastManifestDate { get; set; } 
	}
}
