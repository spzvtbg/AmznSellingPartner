namespace AmznSellingPartner.Clients.Finances.Transfers20240601
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	/// <summary>
	/// The type of payment method.
	/// </summary>
	[JsonConverter(typeof(StringEnumConverter))]
	public enum PaymentMethodType
	{
		/// <summary>
		/// The payment is from a bank account.
		/// </summary>
		[EnumMember(Value = "BANK_ACCOUNT")]
		BANK_ACCOUNT,

		/// <summary>
		/// The payment is from a card.
		/// </summary>
		[EnumMember(Value = "CARD")]
		CARD,

		/// <summary>
		/// The payment is from a [Seller Wallet](https://sell.amazon.com/tools/seller-wallet) virtual bank account.
		/// </summary>
		[EnumMember(Value = "SELLER_WALLET")]
		SELLER_WALLET,
	}
}
