namespace AmznSellingPartner.Clients.Services.Services
{
	using AmznSellingPartner.Clients.Attributes;

	using Newtonsoft.Json;

	using System;
	using System.Collections.Generic;

	/// <summary>
	/// The job details of a service.
	/// </summary>
	public class ServiceJob : BaseClass
	{
		/// <summary>
		/// The date and time of the creation of the job in ISO 8601 format.
		/// </summary>
		[JsonProperty("createTime")]
		public DateTime CreateTime { get; set; }

		/// <summary>
		/// The service job identifier.
		/// </summary>
		[JsonProperty("serviceJobId")]
		public ServiceJobId ServiceJobId { get; set; }

		/// <summary>
		/// The status of the service job.
		/// </summary>
		[JsonProperty("serviceJobStatus")]
		public ServiceJobStatus ServiceJobStatus { get; set; }

		/// <summary>
		/// The scope of work for the order.
		/// </summary>
		[JsonProperty("scopeOfWork")]
		public ScopeOfWork ScopeOfWork { get; set; }

		/// <summary>
		/// Information about the seller of the service job.
		/// </summary>
		[JsonProperty("seller")]
		public Seller Seller { get; set; }

		/// <summary>
		/// Information about the service job provider.
		/// </summary>
		[JsonProperty("serviceJobProvider")]
		public ServiceJobProvider ServiceJobProvider { get; set; }

		/// <summary>
		/// A list of appointment windows preferred by the buyer. Included only if the buyer selected appointment
		/// windows when creating the order.
		/// </summary>
		[JsonProperty("preferredAppointmentTimes")]
		public List<AppointmentTime> PreferredAppointmentTimes { get; set; }

		/// <summary>
		/// A list of appointments.
		/// </summary>
		[JsonProperty("appointments")]
		public List<Appointment> Appointments { get; set; }

		/// <summary>
		/// The Amazon-defined identifier for an order placed by the buyer in 3-7-7 format.
		/// </summary>
		[JsonProperty("serviceOrderId")]
		public OrderId ServiceOrderId { get; set; }

		/// <summary>
		/// The marketplace identifier.
		/// </summary>
		[Pattern("^[A-Z0-9]*")]
		[JsonProperty("marketplaceId")]
		public string MarketplaceId { get; set; }

		/// <summary>
		/// The Amazon-defined identifier for the region scope.
		/// </summary>
		[MinLength(1)]
		[MaxLength(100)]
		[JsonProperty("storeId")]
		public string StoreId { get; set; }

		/// <summary>
		/// Information about the buyer.
		/// </summary>
		[JsonProperty("buyer")]
		public Buyer Buyer { get; set; }

		/// <summary>
		/// A list of items associated with the service job.
		/// </summary>
		[JsonProperty("associatedItems")]
		public List<AssociatedItem> AssociatedItems { get; set; }

		/// <summary>
		/// Information about the location of the service job.
		/// </summary>
		[JsonProperty("serviceLocation")]
		public ServiceLocation ServiceLocation { get; set; }
	}
}
