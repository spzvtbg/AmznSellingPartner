namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Provide these fields only if this shipment is a direct import
	/// </summary>
	public class ImportDetails : BaseClass
	{
		/// <summary>
		/// This is used for import purchase orders only
		/// If the recipient requests, this field will contain the shipment method of payment
		/// </summary>
		[JsonProperty("methodOfPayment")]
		public MethodOfPayment MethodOfPayment { get; set; }

		/// <summary>
		/// The container's seal number
		/// </summary>
		[JsonProperty("sealNumber")]
		public string SealNumber { get; set; }

		/// <summary>
		/// The route and stop details for this shipment
		/// </summary>
		[JsonProperty("route")]
		public Route Route { get; set; }

		/// <summary>
		/// Types and numbers of container(s) for import purchase orders
		/// Can be a comma-separated list if shipment has multiple containers
		/// </summary>
		[MaxLength(64)]
		[JsonProperty("importContainers")]
		public string ImportContainers { get; set; }

		/// <summary>
		/// Billable weight of the direct imports shipment
		/// </summary>
		[JsonProperty("billableWeight")]
		public Weight BillableWeight { get; set; }

		/// <summary>
		/// Date on which the shipment is expected to be shipped
		/// This value should not be in the past and not more than 60 days out in the future
		/// </summary>
		[JsonProperty("estimatedShipByDate")]
		public DateTime EstimatedShipByDate { get; set; }

		/// <summary>
		/// Identification of the instructions on how specified item/carton/pallet should be handled
		/// </summary>
		[JsonProperty("handlingInstructions")]
		public HandlingInstructions HandlingInstructions { get; set; }
	}
}
