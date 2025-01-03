namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Carton reference details.
	/// </summary>
	public class CartonReferenceDetails : BaseClass
	{
		/// <summary>
		/// Pallet level carton count is mandatory for single item pallet and optional for mixed item pallet.
		/// </summary>
		[JsonProperty("cartonCount")]
		public int CartonCount { get; set; }

		/// <summary>
		/// Array of reference numbers for the carton that are part of this pallet/shipment. Please provide the cartonSequ
		/// nceNumber from the 'cartons' segment to refer to that carton's details here.
		/// </summary>
		[IsRequired]
		[JsonProperty("cartonReferenceNumbers")]
		public List<string> CartonReferenceNumbers { get; set; }
	}
}
