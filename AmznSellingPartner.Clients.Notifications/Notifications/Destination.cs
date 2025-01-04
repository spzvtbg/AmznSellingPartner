namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// Information about the destination created when you call the `createDestination` operation.
	/// </summary>
	public class Destination : BaseClass
	{
		/// <summary>
		/// The developer-defined name for this destination.
		/// </summary>
		[JsonProperty("name")]
		[IsRequired]
		[MaxLength(256)]
		public string Name { get; set; } 

		/// <summary>
		/// The destination identifier generated when you created the destination.
		/// </summary>
		[JsonProperty("destinationId")]
		[IsRequired]
		public string DestinationId { get; set; } 

		/// <summary>
		/// The resource that will receive notifications associated with this destination.
		/// </summary>
		[JsonProperty("resource")]
		[IsRequired]
		public DestinationResource Resource { get; set; } 
	}
}
