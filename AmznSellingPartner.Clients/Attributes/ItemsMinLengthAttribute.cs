namespace AmznSellingPartner.Clients.Attributes
{
    public class ItemsMinLengthAttribute : AmznAttribute
    {
        private readonly int length;

        public ItemsMinLengthAttribute(int length)
            => this.length = length;
    }
}
