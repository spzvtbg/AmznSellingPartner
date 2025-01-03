namespace AmznSellingPartner.Clients.Attributes
{
    public class MaxLengthAttribute : AmznAttribute
    {
        private readonly int length;

        public MaxLengthAttribute(int length)
            => this.length = length;
    }
}
