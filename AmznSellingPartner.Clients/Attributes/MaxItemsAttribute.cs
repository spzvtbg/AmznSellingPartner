namespace AmznSellingPartner.Clients.Attributes
{
    public class MaxItemsAttribute : AmznAttribute
    {
        private readonly int length;

        public MaxItemsAttribute(int length)
            => this.length = length;
    }
}
