namespace AmznSellingPartner.Clients.Attributes
{
    public class ItemsMaxLengthAttribute : AmznAttribute
    {
        private readonly int length;

        public ItemsMaxLengthAttribute(int length)
            => this.length = length;
    }
}
