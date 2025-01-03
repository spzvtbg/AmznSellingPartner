namespace AmznSellingPartner.Clients.AmazonWarehousingAndDistribution.Awd20240509
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// Represents an AWD outbound order
	/// </summary>
	public class OutboundOrder : BaseClass
	{
		/// <summary>
		/// Date on which this outbound order was confirmed
		/// </summary>
		[JsonProperty("confirmedOn")]
		public DateTime ConfirmedOn { get; set; }

		/// <summary>
		/// Date on which this outbound order was created
		/// </summary>
		[JsonProperty("createdAt")]
		public DateTime CreatedAt { get; set; }

		/// <summary>
		/// List of packages that are eligible for outbound
		/// </summary>
		[JsonProperty("eligiblePackagesToOutbound")]
		public List<DistributionPackageQuantity> EligiblePackagesToOutbound { get; set; }

		/// <summary>
		/// List of product units that are eligible for outbound
		/// </summary>
		[JsonProperty("eligibleProductsToOutbound")]
		public List<ProductQuantity> EligibleProductsToOutbound { get; set; }

		/// <summary>
		/// Execution errors associated with the outbound order
		/// This field will be populated if the order failed validation
		/// </summary>
		[JsonProperty("executionErrors")]
		public List<OutboundExecutionError> ExecutionErrors { get; set; }

		/// <summary>
		/// Order ID for the outbound order
		/// </summary>
		[IsRequired]
		[JsonProperty("orderId")]
		public string OrderId { get; set; }

		/// <summary>
		/// Order preferences for this outbound order
		/// </summary>
		[JsonProperty("orderPreferences")]
		public List<OrderAttribute> OrderPreferences { get; set; }

		/// <summary>
		/// Status for the outbound order
		/// </summary>
		[IsRequired]
		[JsonProperty("orderStatus")]
		public OutboundStatus OrderStatus { get; set; }

		/// <summary>
		/// List of outbound shipments that are part of this order
		/// </summary>
		[IsRequired]
		[JsonProperty("outboundShipments")]
		public List<OutboundShipment> OutboundShipments { get; set; }

		/// <summary>
		/// List of packages to be outbound
		/// </summary>
		[JsonProperty("packagesToOutbound")]
		public List<DistributionPackageQuantity> PackagesToOutbound { get; set; }

		/// <summary>
		/// List of product units to be outbound
		/// </summary>
		[JsonProperty("productsToOutbound")]
		public List<ProductQuantity> ProductsToOutbound { get; set; }

		/// <summary>
		/// Outbound packages that are shipped after the execution has completed post confirmation
		/// </summary>
		[JsonProperty("shippedOutboundPackages")]
		public List<DistributionPackageQuantity> ShippedOutboundPackages { get; set; }

		/// <summary>
		/// Outbound product units that are shipped after the execution has completed post confirmation
		/// </summary>
		[JsonProperty("shippedOutboundProducts")]
		public List<ProductQuantity> ShippedOutboundProducts { get; set; }

		/// <summary>
		/// Date on which this outbound order was last updated
		/// </summary>
		[JsonProperty("updatedAt")]
		public DateTime UpdatedAt { get; set; }
	}
}
