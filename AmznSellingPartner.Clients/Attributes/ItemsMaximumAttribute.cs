namespace AmznSellingPartner.Clients.Attributes
{
    public class ItemsMaximumAttribute : AmznAttribute
    {
        private readonly double maximum;

        public ItemsMaximumAttribute(double maximum)
            => this.maximum = maximum;
    }
}
