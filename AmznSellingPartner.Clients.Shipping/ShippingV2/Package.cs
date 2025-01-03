namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A package to be shipped through a shipping service offering
	/// </summary>
	public class Package : BaseClass
	{
		[IsRequired]
		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		[IsRequired]
		[JsonProperty("weight")]
		public Weight Weight { get; set; }

		[IsRequired]
		[JsonProperty("insuredValue")]
		public Currency InsuredValue { get; set; }

		/// <summary>
		/// When true, the package contains hazardous materials
		/// Defaults to false
		/// </summary>
		[JsonProperty("isHazmat")]
		public bool IsHazmat { get; set; }

		/// <summary>
		/// The seller name displayed on the label
		/// </summary>
		[JsonProperty("sellerDisplayName")]
		public string SellerDisplayName { get; set; }

		[JsonProperty("charges")]
		public ChargeList Charges { get; set; }

		[IsRequired]
		[JsonProperty("packageClientReferenceId")]
		public PackageClientReferenceId PackageClientReferenceId { get; set; }

		[IsRequired]
		[JsonProperty("items")]
		public ItemList Items { get; set; }
	}
}
