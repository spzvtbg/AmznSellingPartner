namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// This is used only for direct import shipment confirmations.
	/// </summary>
	public class Route : BaseClass
	{
		/// <summary>
		/// The port or location involved in transporting the cargo, as specified in transportation contracts or operation
		/// l plans.
		/// </summary>
		[IsRequired]
		[JsonProperty("stops")]
		public List<Stop> Stops { get; set; }
	}
}
