namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Delivery constraints applicable to this order.
	/// </summary>
	public class ShippingConstraints : BaseClass
	{
		/// <summary>
		/// Indicates if the line item needs to be delivered by pallet.
		/// </summary>
		[JsonProperty("PalletDelivery")]
		public ConstraintType PalletDelivery { get; set; }

		/// <summary>
		/// Indicates that the recipient of the line item must sign to confirm its delivery.
		/// </summary>
		[JsonProperty("SignatureConfirmation")]
		public ConstraintType SignatureConfirmation { get; set; }

		/// <summary>
		/// Indicates that the person receiving the line item must be the same as the intended recipient of the order.
		/// </summary>
		[JsonProperty("RecipientIdentityVerification")]
		public ConstraintType RecipientIdentityVerification { get; set; }

		/// <summary>
		/// Indicates that the carrier must confirm the recipient is of the legal age to receive the line item upon delive
		/// y.
		/// </summary>
		[JsonProperty("RecipientAgeVerification")]
		public ConstraintType RecipientAgeVerification { get; set; }
	}
}
