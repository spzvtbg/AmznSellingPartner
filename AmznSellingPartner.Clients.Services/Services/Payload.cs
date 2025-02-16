namespace AmznSellingPartner.Clients.Services.Services
{
    using Newtonsoft.Json;

    public class Payload : BaseClass
    {
        /// <summary>
        /// Warnings generated during the `assignAppointmentResources` operation.
        /// </summary>
        [JsonProperty("warnings")]
        public WarningList Warnings { get; set; }
    }
}
