namespace AmznSellingPartner.Models.Console.Json
{
    public class JAllOf : JUnhandled
    {
        public string Description { get; set; }

        public string Ref { get; set; }

        public string Type { get; set; }

        public string[] Required { get; set; }

        public JProperties Properties { get; set; }
    }
}