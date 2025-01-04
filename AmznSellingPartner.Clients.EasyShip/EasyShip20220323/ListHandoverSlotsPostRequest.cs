namespace AmznSellingPartner.Clients.EasyShip.EasyShip20220323
{
	using AmznSellingPartner.Clients.Attributes;

	[HttpPost("/easyShip/2022-03-23/timeSlot")]
	public class ListHandoverSlotsPostRequest : BaseHttpRequest
	{
		/// <summary>
		/// The request schema for the `listHandoverSlots` operation.
		/// </summary>
		[InBody("ListHandoverSlotsRequest")]
		public ListHandoverSlotsRequest ListHandoverSlotsRequest { get; set; }
	}
}
