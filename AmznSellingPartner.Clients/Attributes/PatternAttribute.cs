namespace AmznSellingPartner.Clients.Attributes
{
    public class PatternAttribute : AmznAttribute
    {
        private readonly string pattern;

        public PatternAttribute(string pattern) 
            => this.pattern = pattern;
    }
}
