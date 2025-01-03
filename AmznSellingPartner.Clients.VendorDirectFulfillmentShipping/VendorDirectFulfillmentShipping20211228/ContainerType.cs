namespace AmznSellingPartner.Clients.VendorDirectFulfillmentShipping.VendorDirectFulfillmentShipping20211228
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum ContainerType
	{
		/// <summary>
		/// A packing container type that is typically used for drinks or food.
		/// </summary>
		[EnumMember(Value = "Carton")]
		Carton,

		/// <summary>
		/// A flat transport structure which supports goods in a stable fashion while being lifted by a forklift.
		/// </summary>
		[EnumMember(Value = "Pallet")]
		Pallet,
	}
}
