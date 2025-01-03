namespace AmznSellingPartner.Clients.Shipping.ShippingV2
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum AccessPointTypes
	{
		/// <summary>
		/// Counter, aka Helix, is an assisted access point where customers interact with a store associate to collect or
		/// eturn packages
		/// Counter stores do not have Locker
		/// </summary>
		[EnumMember(Value = "HELIX")]
		HELIX,

		/// <summary>
		/// It denotes a physical Locker present at Locker+ stores
		/// </summary>
		[EnumMember(Value = "CAMPUS_LOCKER")]
		CAMPUS_LOCKER,

		/// <summary>
		/// Omni lockers are similar to core lockers installed at apartment buildings
		/// Core and Omni will have common base hardware platform
		/// </summary>
		[EnumMember(Value = "OMNI_LOCKER")]
		OMNI_LOCKER,

		/// <summary>
		/// Odin lockers rely on Bluetooth connection as there is no screen or scanner on the locker
		/// Drivers, customers, and even technicians can interact with the locker using an app (different depending on th
		/// user)
		/// </summary>
		[EnumMember(Value = "ODIN_LOCKER")]
		ODIN_LOCKER,

		/// <summary>
		/// Dobby lockers are Odin lockers installed at apartment complexes and available only to residents
		/// </summary>
		[EnumMember(Value = "DOBBY_LOCKER")]
		DOBBY_LOCKER,

		/// <summary>
		/// Core lockers are the traditional and initial style of lockers when Hub was launched
		/// Core lockers have a screen, keypad and scanner
		/// Customer either enter their pickup code using the Locker screen or scan pickup code barcode to pick up their
		/// package
		/// </summary>
		[EnumMember(Value = "CORE_LOCKER")]
		CORE_LOCKER,

		/// <summary>
		/// Networks that are owned end-to-end by commercial carriers (CC - e
		/// g
		/// DHL, UPS, DPD and Postal organizations), who operate both the transportation leg and the access point aspect
		/// These networks offer a range of pickup points including: 3P Lockers, legacy Postal Offices, 3P Counters (e
		/// g
		/// Gas Stations and Retail Outlets - supermarkets, bookstores, news-stands etc)
		/// </summary>
		[EnumMember(Value = "3P")]
		_3P,

		/// <summary>
		/// Locker+, formerly known as Campus, are attended, physical stores, where the Locker is used dynamically by the
		/// taff to keep packages ready for customer pickup
		/// Locker+ store can have multiple Lockers installed,
		/// </summary>
		[EnumMember(Value = "CAMPUS_ROOM")]
		CAMPUS_ROOM,
	}
}
