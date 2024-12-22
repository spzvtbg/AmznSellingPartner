namespace AmznSellingPartner.Models.Console.Json
{
    using AmznSellingPartner.Models.Console.CSharp;

    using System.Collections.Generic;
    using System.Runtime.Serialization;

    public class JSwagger
    {
        public JPaths Paths { get; set; }

        public JDefinitions Definitions { get; set; }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext _)
        {
            if (this.Definitions is null)
            {
                return;
            }

            foreach (var (name, definition) in this.Definitions)
            {
                definition.Name = name.Capitalize();
            }
        }

        public IEnumerable<CSNamespace> ToCSNamespaces()
        {
            var definitions = this.Definitions.ToCSClasses();
            var namespaces = new List<CSNamespace>();

            foreach (var tag in this.Paths.GetTags())
            {
                var csNamespace = new CSNamespace();
                csNamespace.Name = $"AmznSellingPartner.Models.{tag.Capitalize()}";
                csNamespace.Classes = definitions;

                namespaces.Add(csNamespace);
            }

            return namespaces;
        }
    }
}
