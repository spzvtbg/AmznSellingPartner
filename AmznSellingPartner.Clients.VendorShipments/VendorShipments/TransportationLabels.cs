namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The request schema for the GetShipmentLabels operation.
	/// </summary>
	public class TransportationLabels : BaseClass
	{
		[JsonProperty("pagination")]
		public Pagination Pagination { get; set; }

		/// <summary>
		/// A list of one or more ShipmentLabels.
		/// </summary>
		[JsonProperty("transportLabels")]
		public List<TransportLabel> TransportLabels { get; set; }
	}
}
