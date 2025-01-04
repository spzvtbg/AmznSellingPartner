namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A package to be shipped through a shipping service offering.
	/// </summary>
	public class Package : BaseClass
	{
		[JsonProperty("dimensions")]
		[IsRequired]
		public Dimensions Dimensions { get; set; } 

		[JsonProperty("weight")]
		[IsRequired]
		public Weight Weight { get; set; } 

		[JsonProperty("insuredValue")]
		[IsRequired]
		public Currency InsuredValue { get; set; } 

		/// <summary>
		/// When true, the package contains hazardous materials. Defaults to false.
		/// </summary>
		[JsonProperty("isHazmat")]
		public bool IsHazmat { get; set; } 

		/// <summary>
		/// The seller name displayed on the label.
		/// </summary>
		[JsonProperty("sellerDisplayName")]
		public string SellerDisplayName { get; set; } 

		[JsonProperty("charges")]
		public ChargeList Charges { get; set; } 

		[JsonProperty("packageClientReferenceId")]
		[IsRequired]
		public PackageClientReferenceId PackageClientReferenceId { get; set; } 

		[JsonProperty("items")]
		[IsRequired]
		public ItemList Items { get; set; } 
	}
}
