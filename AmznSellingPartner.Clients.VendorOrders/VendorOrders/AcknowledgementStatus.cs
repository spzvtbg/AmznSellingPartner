namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;

	using System.Collections.Generic;

	public class AcknowledgementStatus : BaseClass
	{
		/// <summary>
		/// Confirmation status of line item
		/// </summary>
		[JsonProperty("confirmationStatus")]
		public ConfirmationStatus ConfirmationStatus { get; set; }

		/// <summary>
		/// Item quantities accepted by vendor to be shipped
		/// </summary>
		[JsonProperty("acceptedQuantity")]
		public ItemQuantity AcceptedQuantity { get; set; }

		/// <summary>
		/// Item quantities rejected by vendor
		/// </summary>
		[JsonProperty("rejectedQuantity")]
		public ItemQuantity RejectedQuantity { get; set; }

		/// <summary>
		/// Details of item quantity confirmed
		/// </summary>
		[JsonProperty("acknowledgementStatusDetails")]
		public List<AcknowledgementStatusDetails> AcknowledgementStatusDetails { get; set; }
	}
}
