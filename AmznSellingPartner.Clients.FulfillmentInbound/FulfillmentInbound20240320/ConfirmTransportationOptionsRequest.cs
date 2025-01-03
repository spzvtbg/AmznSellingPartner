namespace AmznSellingPartner.Clients.FulfillmentInbound.FulfillmentInbound20240320
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The `confirmTransportationOptions` request.
	/// </summary>
	public class ConfirmTransportationOptionsRequest : BaseClass
	{
		/// <summary>
		/// Information needed to confirm one of the available transportation options.
		/// </summary>
		[IsRequired]
		[MinItems(1)]
		[JsonProperty("transportationSelections")]
		public List<TransportationSelection> TransportationSelections { get; set; }
	}
}
