namespace AmznSellingPartner.Clients.VendorOrders.VendorOrders
{
	using Newtonsoft.Json;
	using Newtonsoft.Json.Converters;

	using System.Runtime.Serialization;

	[JsonConverter(typeof(StringEnumConverter))]
	public enum InternationalCommercialTerms
	{
		/// <summary>
		/// Places the maximum obligation on the buyer and minimum obligations on the seller. The seller makes the
		/// goods available at its premises. The buyer is responsible for all costs of the transportation of the
		/// shipment and bears all the risks for bringing the goods to their final destination.
		/// </summary>
		[EnumMember(Value = "ExWorks")]
		ExWorks,

		/// <summary>
		/// The seller hands over the goods, cleared for export, into the disposal of the carrier (named by the buyer).
		/// The buyer pays for all the additional costs of transportation and risk passes when the goods are handed
		/// over to the carrier.
		/// </summary>
		[EnumMember(Value = "FreeCarrier")]
		FreeCarrier,

		/// <summary>
		/// Ocean shipments only. The seller must deliver the goods alongside the ship at the named port, and clear
		/// the goods for export. The buyer pays for all the additional costs of transportation and risk passes when
		/// the goods are alongside the ship.
		/// </summary>
		[EnumMember(Value = "FreeOnBoard")]
		FreeOnBoard,

		/// <summary>
		/// Ocean shipments only. The seller must load the goods on board the vessel, cleared for export. The buyer
		/// pays for all the additional costs of transportation and risk passes when the goods are loaded on the
		/// ship.
		/// </summary>
		[EnumMember(Value = "FreeAlongSideShip")]
		FreeAlongSideShip,

		/// <summary>
		/// The seller pays for transportation to the named port of destination, but risk transfers to the buyer
		/// upon handing goods over to the first carrier. The buyer pays for all destination charges.
		/// </summary>
		[EnumMember(Value = "CarriagePaidTo")]
		CarriagePaidTo,

		/// <summary>
		/// Ocean shipments only. Seller pays for transportation to the named port of destination, but risk transfers
		/// to the buyer once the goods are loaded on the vessel. The buyer pays for all destination charges.
		/// </summary>
		[EnumMember(Value = "CostAndFreight")]
		CostAndFreight,

		/// <summary>
		/// Seller pays for transportation and insurance to the named port of destination, but risk transfers to
		/// the buyer upon handing goods over to the first carrier. The buyer pays for all destination charges.
		/// </summary>
		[EnumMember(Value = "CarriageAndInsurancePaidTo")]
		CarriageAndInsurancePaidTo,

		/// <summary>
		/// Ocean shipments only. Seller pays for transportation and insurance to the named port of destination,
		/// but risk transfers to the buyer once the goods are loaded on the vessel. The buyer pays for all destination
		/// charges.
		/// </summary>
		[EnumMember(Value = "CostInsuranceAndFreight")]
		CostInsuranceAndFreight,

		/// <summary>
		/// Seller pays for transportation up to the destination terminal, and risks up to the point that the goods
		/// are unloaded at the terminal. The buyer pays for import clearance, duties & taxes and delivery costs
		/// .
		/// </summary>
		[EnumMember(Value = "DeliveredAtTerminal")]
		DeliveredAtTerminal,

		/// <summary>
		/// Seller pays for transportation to the named destination, and risk transfers at the point that the goods
		/// are ready for unloading by the buyer. The buyer pays for import clearance, duties & taxes and delivery
		/// costs.
		/// </summary>
		[EnumMember(Value = "DeliveredAtPlace")]
		DeliveredAtPlace,

		/// <summary>
		/// Seller is responsible for delivering the goods to the named place in the country of the buyer, and pays
		/// all costs in bringing the goods to the destination including import duties and taxes. This term places
		/// the maximum obligations on the seller and minimum obligations on the buyer.
		/// </summary>
		[EnumMember(Value = "DeliverDutyPaid")]
		DeliverDutyPaid,
	}
}
