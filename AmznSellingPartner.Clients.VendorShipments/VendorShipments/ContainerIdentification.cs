namespace AmznSellingPartner.Clients.VendorShipments.VendorShipments
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// A list of carton identifiers.
	/// </summary>
	public class ContainerIdentification : BaseClass
	{
		/// <summary>
		/// The container identification type.
		/// </summary>
		[JsonProperty("containerIdentificationType")]
		[IsRequired]
		public ContainerIdentificationType ContainerIdentificationType { get; set; } 

		/// <summary>
		/// Container identification number that adheres to the definition of the container identification
		/// type.
		/// </summary>
		[JsonProperty("containerIdentificationNumber")]
		[IsRequired]
		public string ContainerIdentificationNumber { get; set; } 
	}
}
