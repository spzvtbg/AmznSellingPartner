namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using Newtonsoft.Json;

	/// <summary>
	/// Contains the business invoice tax information. Available only in the TR marketplace.
	/// </summary>
	public class BuyerTaxInformation : BaseClass
	{
		/// <summary>
		/// Business buyer's company legal name.
		/// </summary>
		[JsonProperty("BuyerLegalCompanyName")]
		public string BuyerLegalCompanyName { get; set; } 

		/// <summary>
		/// Business buyer's address.
		/// </summary>
		[JsonProperty("BuyerBusinessAddress")]
		public string BuyerBusinessAddress { get; set; } 

		/// <summary>
		/// Business buyer's tax registration ID.
		/// </summary>
		[JsonProperty("BuyerTaxRegistrationId")]
		public string BuyerTaxRegistrationId { get; set; } 

		/// <summary>
		/// Business buyer's tax office.
		/// </summary>
		[JsonProperty("BuyerTaxOffice")]
		public string BuyerTaxOffice { get; set; } 
	}
}
