namespace AmznSellingPartner.Clients.Tokens.Tokens20210301
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// Model of a restricted resource.
	/// </summary>
	public class RestrictedResource : BaseClass
	{
		/// <summary>
		/// The HTTP method in the restricted resource.
		/// </summary>
		[IsRequired]
		[JsonProperty("method")]
		public Method Method { get; set; }

		/// <summary>
		/// The path in the restricted resource. Here are some path examples: - ```/orders/v0/orders```. For getting an RD
		/// for the getOrders operation of the Orders API. For bulk orders. - ```/orders/v0/orders/123-1234567-1234567```
		/// For getting an RDT for the getOrder operation of the Orders API. For a specific order. - ```/orders/v0/orders
		/// 123-1234567-1234567/orderItems```. For getting an RDT for the getOrderItems operation of the Orders API. For t
		/// e order items in a specific order. - ```/mfn/v0/shipments/FBA1234ABC5D```. For getting an RDT for the getShipm
		/// nt operation of the Shipping API. For a specific shipment. - ```/mfn/v0/shipments/{shipmentId}```. For getting
		/// an RDT for the getShipment operation of the Shipping API. For any of a selling partner's shipments that you sp
		/// cify when you call the getShipment operation.
		/// </summary>
		[IsRequired]
		[JsonProperty("path")]
		public string Path { get; set; }

		/// <summary>
		/// Indicates the type of Personally Identifiable Information requested. This parameter is required only when gett
		/// ng an RDT for use with the getOrder, getOrders, or getOrderItems operation of the Orders API. For more informa
		/// ion, see the [Tokens API Use Case Guide](doc:tokens-api-use-case-guide). Possible values include: - **buyerInf
		/// **. On the order level this includes general identifying information about the buyer and tax-related informati
		/// n. On the order item level this includes gift wrap information and custom order information, if available. - *
		/// shippingAddress**. This includes information for fulfilling orders. - **buyerTaxInformation**. This includes i
		/// formation for issuing tax invoices.
		/// </summary>
		[JsonProperty("dataElements")]
		public List<string> DataElements { get; set; }
	}
}
