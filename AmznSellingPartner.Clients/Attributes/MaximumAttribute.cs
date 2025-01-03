namespace AmznSellingPartner.Clients.Attributes
{
    public class MaximumAttribute : AmznAttribute
    {
        private readonly double maximim;

        public MaximumAttribute(double maximim)
            => this.maximim = maximim;
    }
}
