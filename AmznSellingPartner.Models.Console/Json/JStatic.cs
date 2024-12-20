namespace AmznSellingPartner.Models.Console.Json
{
    using Newtonsoft.Json.Linq;

    public class JStatic : JUnhandled
    {
        public JToken Request { get; set; }

        public JToken Response { get; set; }
    }
}
