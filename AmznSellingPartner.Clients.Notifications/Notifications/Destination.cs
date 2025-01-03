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
		[IsRequired]
		[MaxLength(256)]
		[JsonProperty("name")]
		public string Name { get; set; }

		/// <summary>
		/// The destination identifier generated when you created the destination.
		/// </summary>
		[IsRequired]
		[JsonProperty("destinationId")]
		public string DestinationId { get; set; }

		/// <summary>
		/// The resource that will receive notifications associated with this destination.
		/// </summary>
		[IsRequired]
		[JsonProperty("resource")]
		public DestinationResource Resource { get; set; }
	}
}
