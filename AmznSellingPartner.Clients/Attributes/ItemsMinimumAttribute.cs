namespace AmznSellingPartner.Clients.Attributes
{
    public class ItemsMinimumAttribute : AmznAttribute
    {
        private readonly double minimum;

        public ItemsMinimumAttribute(double minimum)
            => this.minimum = minimum;
    }
}
