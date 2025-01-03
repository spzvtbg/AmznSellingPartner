namespace AmznSellingPartner
{
    using Newtonsoft.Json.Linq;

    internal class AmznSchema : AmznUnhandled
    {
        public string Type { get; set; }

        public string Ref { get; set; }

        public JToken Example { get; set; }
    }
}
