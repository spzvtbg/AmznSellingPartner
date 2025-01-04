namespace AmznSellingPartner.Clients.Orders.OrdersV0
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System.Collections.Generic;

	/// <summary>
	/// The types of verification details that may be provided for the order and the criteria required for when
	/// the type of verification detail can be provided. The types of verification details allowed depend on
	/// the type of regulated product and will not change order to order.
	/// </summary>
	public class ValidVerificationDetail : BaseClass
	{
		/// <summary>
		/// A supported type of verification detail. The type indicates which verification detail could be shared
		/// while updating the regulated order. Valid value: `prescriptionDetail`.
		/// </summary>
		[JsonProperty("VerificationDetailType")]
		[IsRequired]
		public string VerificationDetailType { get; set; } 

		/// <summary>
		/// A list of valid verification statuses where the associated verification detail type may be provided.
		/// For example, if the value of this field is ["Approved"], calls to provide the associated verification
		/// detail will fail for orders with a `VerificationStatus` of `Pending`, `Rejected`, `Expired`, or `Can
		/// celled`.
		/// </summary>
		[JsonProperty("ValidVerificationStatuses")]
		[IsRequired]
		public List<VerificationStatus> ValidVerificationStatuses { get; set; } 
	}
}
