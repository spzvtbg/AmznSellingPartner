namespace AmznSellingPartner.Clients.Notifications.Notifications
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	/// <summary>
	/// The request schema for the `createDestination` operation.
	/// </summary>
	public class CreateDestinationRequest : BaseClass
	{
		/// <summary>
		/// The information required to create a destination resource. Applications should use one resource type
		/// (sqs or eventBridge) per destination.
		/// </summary>
		[IsRequired]
		[JsonProperty("resourceSpecification")]
		public DestinationResourceSpecification ResourceSpecification { get; set; }

		/// <summary>
		/// A developer-defined name to help identify this destination.
		/// </summary>
		[IsRequired]
		[JsonProperty("name")]
		public string Name { get; set; }
	}
}
