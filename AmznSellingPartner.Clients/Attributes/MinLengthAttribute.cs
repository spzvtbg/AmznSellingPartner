namespace AmznSellingPartner.Clients.Attributes
{
    public class MinLengthAttribute : AmznAttribute
    {
        private readonly int length;

        public MinLengthAttribute(int length)
            => this.length = length;
    }
}
