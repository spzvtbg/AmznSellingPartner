namespace AmznSellingPartner.Clients.Attributes
{
    public class MinItemsAttribute : AmznAttribute
    {
        private readonly int length;

        public MinItemsAttribute(int length)
            => this.length = length;
    }
}
