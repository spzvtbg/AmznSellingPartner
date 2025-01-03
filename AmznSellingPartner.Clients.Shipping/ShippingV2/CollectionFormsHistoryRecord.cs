namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;

	using System;

	/// <summary>
	/// Active Account Details
	/// </summary>
	public class CollectionFormsHistoryRecord : BaseClass
	{
		[JsonProperty("carrierName")]
		public CarrierName CarrierName { get; set; }

		/// <summary>
		/// Creation Time for this account
		/// </summary>
		[JsonProperty("creationDate")]
		public DateTime CreationDate { get; set; }

		[JsonProperty("generationStatus")]
		public GenerationStatus GenerationStatus { get; set; }

		[JsonProperty("collectionFormId")]
		public CollectionFormId CollectionFormId { get; set; }

		[JsonProperty("shipFromAddress")]
		public Address ShipFromAddress { get; set; }
	}
}
