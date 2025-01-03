namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Details of the Pallet/Tare being shipped.
	/// </summary>
	public class Pallet : BaseClass
	{
		/// <summary>
		/// A list of pallet identifiers.
		/// </summary>
		[IsRequired]
		[JsonProperty("palletIdentifiers")]
		public List<ContainerIdentification> PalletIdentifiers { get; set; }

		/// <summary>
		/// Number of layers per pallet. Only applicable to container type Pallet.
		/// </summary>
		[JsonProperty("tier")]
		public int Tier { get; set; }

		/// <summary>
		/// Number of cartons per layer on the pallet. Only applicable to container type Pallet.
		/// </summary>
		[JsonProperty("block")]
		public int Block { get; set; }

		[JsonProperty("dimensions")]
		public Dimensions Dimensions { get; set; }

		[JsonProperty("weight")]
		public Weight Weight { get; set; }

		/// <summary>
		/// Carton reference details.
		/// </summary>
		[JsonProperty("cartonReferenceDetails")]
		public CartonReferenceDetails CartonReferenceDetails { get; set; }

		/// <summary>
		/// A list of container item details.
		/// </summary>
		[JsonProperty("items")]
		public List<ContainerItem> Items { get; set; }
	}
}
