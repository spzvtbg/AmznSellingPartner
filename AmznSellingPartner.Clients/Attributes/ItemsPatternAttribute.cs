namespace AmznSellingPartner.Clients.Attributes
{
    public class ItemsPatternAttribute : AmznAttribute
    {
        private readonly string pattern;

        public ItemsPatternAttribute(string pattern) 
            => this.pattern = pattern;
    }
}
