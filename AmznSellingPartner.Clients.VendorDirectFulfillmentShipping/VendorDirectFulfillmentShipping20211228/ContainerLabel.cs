namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The details of the container label
	/// </summary>
	public class ContainerLabel : BaseClass
	{
		/// <summary>
		/// The container (pallet) tracking identifier from the shipping carrier
		/// </summary>
		[JsonProperty("containerTrackingNumber")]
		public string ContainerTrackingNumber { get; set; }

		/// <summary>
		/// The `Base64encoded` string of the container label content
		/// </summary>
		[IsRequired]
		[JsonProperty("content")]
		public string Content { get; set; }

		/// <summary>
		/// The format of the container label
		/// </summary>
		[IsRequired]
		[JsonProperty("format")]
		public ContainerLabelFormat Format { get; set; }
	}
}
