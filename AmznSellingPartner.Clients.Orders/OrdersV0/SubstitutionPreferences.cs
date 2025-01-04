namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Substitution preferences for an order item.
	/// </summary>
	public class SubstitutionPreferences : BaseClass
	{
		/// <summary>
		/// The type of substitution that these preferences represent.
		/// </summary>
		[JsonProperty("SubstitutionType")]
		[IsRequired]
		public SubstitutionType SubstitutionType { get; set; } 

		/// <summary>
		/// Substitution options for the order item.
		/// </summary>
		[JsonProperty("SubstitutionOptions")]
		public SubstitutionOptionList SubstitutionOptions { get; set; } 
	}
}
