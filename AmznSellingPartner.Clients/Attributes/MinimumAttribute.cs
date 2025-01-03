namespace AmznSellingPartner.Clients.Attributes
{
    public class MinimumAttribute : AmznAttribute
    {
        private readonly double minimum;

        public MinimumAttribute(double minimum)
            => this.minimum = minimum;
    }
}
