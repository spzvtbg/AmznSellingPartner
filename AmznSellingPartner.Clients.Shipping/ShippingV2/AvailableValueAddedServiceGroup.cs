namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The value-added services available for purchase with a shipping service offering.
	/// </summary>
	public class AvailableValueAddedServiceGroup : BaseClass
	{
		/// <summary>
		/// The type of the value-added service group.
		/// </summary>
		[JsonProperty("groupId")]
		[IsRequired]
		public string GroupId { get; set; }

		/// <summary>
		/// The name of the value-added service group.
		/// </summary>
		[JsonProperty("groupDescription")]
		[IsRequired]
		public string GroupDescription { get; set; }

		/// <summary>
		/// When true, one or more of the value-added services listed must be specified.
		/// </summary>
		[JsonProperty("isRequired")]
		[IsRequired]
		public bool IsRequired { get; set; }

		/// <summary>
		/// A list of optional value-added services available for purchase with a shipping service offering.
		/// </summary>
		[JsonProperty("valueAddedServices")]
		public List<ValueAddedService> ValueAddedServices { get; set; }
	}
}
