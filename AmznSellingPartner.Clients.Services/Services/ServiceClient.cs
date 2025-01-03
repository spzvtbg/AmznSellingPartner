namespace AmznSellingPartner.Clients.Services.Services
{
	using System;
	using System.Threading.Tasks;

	public class ServiceClient(Uri baseAddress) : BaseHttpClient((baseAddress))
	{
		/// <summary>
		/// Gets details of service job indicated by the provided `serviceJobID`.  **Usage Plan:**  | Rate (requests per s
		/// cond) | Burst | | ---- | ---- | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage pl
		/// n rate limits that were applied to the requested operation, when available. The table above indicates the defa
		/// lt rate and burst values for this operation. Selling partners whose business demands require higher throughput
		/// may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Li
		/// its in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetServiceJobByServiceJobIdGetResponse> GetServiceJobByServiceJobIdAsync(GetServiceJobByServiceJobIdGetRequest request)
		    => await this.SendAsync<GetServiceJobByServiceJobIdGetResponse>(request);

		/// <summary>
		/// Cancels the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (requests
		/// er second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usag
		/// plan rate limits that were applied to the requested operation, when available. The table above indicates the
		/// efault rate and burst values for this operation. Selling partners whose business demands require higher throug
		/// put may see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rat
		/// Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelServiceJobByServiceJobIdPutResponse> CancelServiceJobByServiceJobIdAsync(CancelServiceJobByServiceJobIdPutRequest request)
		    => await this.SendAsync<CancelServiceJobByServiceJobIdPutResponse>(request);

		/// <summary>
		/// Completes the service job indicated by the service job identifier specified.  **Usage Plan:**  | Rate (request
		/// per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the us
		/// ge plan rate limits that were applied to the requested operation, when available. The table above indicates th
		/// default rate and burst values for this operation. Selling partners whose business demands require higher thro
		/// ghput may see higher rate and burst values than those shown here. For more information, see [Usage Plans and R
		/// te Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CompleteServiceJobByServiceJobIdPutResponse> CompleteServiceJobByServiceJobIdAsync(CompleteServiceJobByServiceJobIdPutRequest request)
		    => await this.SendAsync<CompleteServiceJobByServiceJobIdPutResponse>(request);

		/// <summary>
		/// Gets service job details for the specified filter query.  **Usage Plan:**  | Rate (requests per second) | Burs
		/// | | ---- | ---- | | 10 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limit
		/// that were applied to the requested operation, when available. The table above indicates the default rate and
		/// urst values for this operation. Selling partners whose business demands require higher throughput may see high
		/// r rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in the S
		/// lling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetServiceJobsGetResponse> GetServiceJobsAsync(GetServiceJobsGetRequest request)
		    => await this.SendAsync<GetServiceJobsGetResponse>(request);

		/// <summary>
		/// Adds an appointment to the service job indicated by the service job identifier specified.  **Usage Plan:**  |
		/// ate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header r
		/// turns the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// indicates the default rate and burst values for this operation. Selling partners whose business demands requir
		/// higher throughput may see higher rate and burst values than those shown here. For more information, see [Usag
		/// Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AddAppointmentForServiceJobByServiceJobIdPostResponse> AddAppointmentForServiceJobByServiceJobIdAsync(AddAppointmentForServiceJobByServiceJobIdPostRequest request)
		    => await this.SendAsync<AddAppointmentForServiceJobByServiceJobIdPostResponse>(request);

		/// <summary>
		/// Reschedules an appointment for the service job indicated by the service job identifier specified.  **Usage Pla
		/// :**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response
		/// eader returns the usage plan rate limits that were applied to the requested operation, when available. The tab
		/// e above indicates the default rate and burst values for this operation. Selling partners whose business demand
		/// require higher throughput may see higher rate and burst values than those shown here. For more information, s
		/// e [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<RescheduleAppointmentForServiceJobByServiceJobIdPostResponse> RescheduleAppointmentForServiceJobByServiceJobIdAsync(RescheduleAppointmentForServiceJobByServiceJobIdPostRequest request)
		    => await this.SendAsync<RescheduleAppointmentForServiceJobByServiceJobIdPostResponse>(request);

		/// <summary>
		/// Assigns new resource(s) or overwrite/update the existing one(s) to a service job appointment.  **Usage Plan:**
		/// | Rate (requests per second) | Burst | | ---- | ---- | | 1 | 2 |  The `x-amzn-RateLimit-Limit` response heade
		/// returns the usage plan rate limits that were applied to the requested operation, when available. The table ab
		/// ve indicates the default rate and burst values for this operation. Selling partners whose business demands req
		/// ire higher throughput may see higher rate and burst values than those shown here. For more information, see [U
		/// age Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<AssignAppointmentResourcesPutResponse> AssignAppointmentResourcesAsync(AssignAppointmentResourcesPutRequest request)
		    => await this.SendAsync<AssignAppointmentResourcesPutResponse>(request);

		/// <summary>
		/// Updates the appointment fulfillment data related to a given `jobID` and `appointmentID`.  **Usage Plan:**  | R
		/// te (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header re
		/// urns the usage plan rate limits that were applied to the requested operation, when available. The table above
		/// ndicates the default rate and burst values for this operation. Selling partners whose business demands require
		/// higher throughput may see higher rate and burst values than those shown here. For more information, see [Usage
		/// Plans and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<SetAppointmentFulfillmentDataPutResponse> SetAppointmentFulfillmentDataAsync(SetAppointmentFulfillmentDataPutRequest request)
		    => await this.SendAsync<SetAppointmentFulfillmentDataPutResponse>(request);

		/// <summary>
		/// Provides capacity slots in a format similar to availability records.  **Usage Plan:**  | Rate (requests per se
		/// ond) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan
		/// rate limits that were applied to the requested operation, when available. The table above indicates the defaul
		/// rate and burst values for this operation. Selling partners whose business demands require higher throughput m
		/// y see higher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limi
		/// s in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetRangeSlotCapacityPostResponse> GetRangeSlotCapacityAsync(GetRangeSlotCapacityPostRequest request)
		    => await this.SendAsync<GetRangeSlotCapacityPostResponse>(request);

		/// <summary>
		/// Provides capacity in fixed-size slots.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ----
		/// | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applie
		/// to the requested operation, when available. The table above indicates the default rate and burst values for t
		/// is operation. Selling partners whose business demands require higher throughput may see higher rate and burst
		/// alues than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API
		/// (doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetFixedSlotCapacityPostResponse> GetFixedSlotCapacityAsync(GetFixedSlotCapacityPostRequest request)
		    => await this.SendAsync<GetFixedSlotCapacityPostResponse>(request);

		/// <summary>
		/// Update the schedule of the given resource.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | -
		/// -- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were app
		/// ied to the requested operation, when available. The table above indicates the default rate and burst values fo
		/// this operation. Selling partners whose business demands require higher throughput may see higher rate and bur
		/// t values than those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner
		/// PI](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateSchedulePutResponse> UpdateScheduleAsync(UpdateSchedulePutRequest request)
		    => await this.SendAsync<UpdateSchedulePutResponse>(request);

		/// <summary>
		/// Create a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The
		/// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested
		/// operation, when available. The table above indicates the default rate and burst values for this operation. Sel
		/// ing partners whose business demands require higher throughput may see higher rate and burst values than those
		/// hown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-
		/// nd-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateReservationPostResponse> CreateReservationAsync(CreateReservationPostRequest request)
		    => await this.SendAsync<CreateReservationPostResponse>(request);

		/// <summary>
		/// Cancel a reservation.   **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  Th
		/// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requeste
		/// operation, when available. The table above indicates the default rate and burst values for this operation. Se
		/// ling partners whose business demands require higher throughput may see higher rate and burst values than those
		/// shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans
		/// and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CancelReservationDeleteResponse> CancelReservationAsync(CancelReservationDeleteRequest request)
		    => await this.SendAsync<CancelReservationDeleteResponse>(request);

		/// <summary>
		/// Update a reservation.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The
		/// `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the requested
		/// operation, when available. The table above indicates the default rate and burst values for this operation. Sel
		/// ing partners whose business demands require higher throughput may see higher rate and burst values than those
		/// hown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usage-plans-
		/// nd-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<UpdateReservationPutResponse> UpdateReservationAsync(UpdateReservationPutRequest request)
		    => await this.SendAsync<UpdateReservationPutResponse>(request);

		/// <summary>
		/// Gets appointment slots for the service associated with the service job id specified.  **Usage Plan:**  | Rate
		/// requests per second) | Burst | | ---- | ---- | | 5 | 20 |  The `x-amzn-RateLimit-Limit` response header return
		/// the usage plan rate limits that were applied to the requested operation, when available. The table above indi
		/// ates the default rate and burst values for this operation. Selling partners whose business demands require hig
		/// er throughput may see higher rate and burst values than those shown here. For more information, see [Usage Pla
		/// s and Rate Limits in the Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetAppointmmentSlotsByJobIdGetResponse> GetAppointmmentSlotsByJobIdAsync(GetAppointmmentSlotsByJobIdGetRequest request)
		    => await this.SendAsync<GetAppointmmentSlotsByJobIdGetResponse>(request);

		/// <summary>
		/// Gets appointment slots as per the service context specified.  **Usage Plan:**  | Rate (requests per second) |
		/// urst | | ---- | ---- | | 20 | 40 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate l
		/// mits that were applied to the requested operation, when available. The table above indicates the default rate
		/// nd burst values for this operation. Selling partners whose business demands require higher throughput may see
		/// igher rate and burst values than those shown here. For more information, see [Usage Plans and Rate Limits in t
		/// e Selling Partner API](doc:usage-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<GetAppointmentSlotsGetResponse> GetAppointmentSlotsAsync(GetAppointmentSlotsGetRequest request)
		    => await this.SendAsync<GetAppointmentSlotsGetResponse>(request);

		/// <summary>
		/// Creates an upload destination.  **Usage Plan:**  | Rate (requests per second) | Burst | | ---- | ---- | | 5 |
		/// 0 |  The `x-amzn-RateLimit-Limit` response header returns the usage plan rate limits that were applied to the
		/// equested operation, when available. The table above indicates the default rate and burst values for this opera
		/// ion. Selling partners whose business demands require higher throughput may see higher rate and burst values th
		/// n those shown here. For more information, see [Usage Plans and Rate Limits in the Selling Partner API](doc:usa
		/// e-plans-and-rate-limits-in-the-sp-api).
		/// </summary>
		public async Task<CreateServiceDocumentUploadDestinationPostResponse> CreateServiceDocumentUploadDestinationAsync(CreateServiceDocumentUploadDestinationPostRequest request)
		    => await this.SendAsync<CreateServiceDocumentUploadDestinationPostResponse>(request);
	}
}
