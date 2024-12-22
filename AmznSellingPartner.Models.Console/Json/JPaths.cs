namespace AmznSellingPartner.Models.Console.Json
{
    using System.Collections.Generic;

    public class JPaths : Dictionary<string, JPath>
    {
        internal IEnumerable<string> GetTags()
        {
            var tags = new HashSet<string>();

            foreach (var path in this.Values)
            {
                foreach (var tag in path.GetTags())
                {
                    tags.Add(tag);   
                }
            }

            return tags;
        }
    }
}