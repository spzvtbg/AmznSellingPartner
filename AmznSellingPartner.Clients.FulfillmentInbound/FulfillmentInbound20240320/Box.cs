namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Contains information about a box that is used in the inbound plan
	/// The box is a container that holds multiple items
	/// </summary>
	public class Box : BaseClass
	{
		/// <summary>
		/// The ID provided by Amazon that identifies a given box
		/// This ID is comprised of the external shipment ID (which is generated after transportation has been confirmed)
		/// and the index of the box
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("boxId")]
		public string BoxId { get; set; }

		[JsonProperty("contentInformationSource")]
		public BoxContentInformationSource ContentInformationSource { get; set; }

		[JsonProperty("destinationRegion")]
		public Region DestinationRegion { get; set; }

		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		/// <summary>
		/// Items contained within the box
		/// </summary>
		[JsonProperty("items")]
		public List<Item> Items { get; set; }

		/// <summary>
		/// Primary key to uniquely identify a Package (Box or Pallet)
		/// </summary>
		[IsRequired]
		[Pattern("^[a-zA-Z0-9-]*")]
		[MinLength(38)]
		[MaxLength(38)]
		[JsonProperty("packageId")]
		public string PackageId { get; set; }

		/// <summary>
		/// The number of containers where all other properties like weight or dimensions are identical
		/// </summary>
		[Minimum(1)]
		[Maximum(10000)]
		[JsonProperty("quantity")]
		public int Quantity { get; set; }

		/// <summary>
		/// Template name of the box
		/// </summary>
		[MinLength(1)]
		[MaxLength(1024)]
		[JsonProperty("templateName")]
		public string TemplateName { get; set; }

		[JsonProperty("weight")]
		public Weight Weight { get; set; }
	}
}
