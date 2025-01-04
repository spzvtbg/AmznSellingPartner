namespace AmznSellingPartner
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class CsClient(string name) : CsType(name)
    {
        private ICollection<CsMethod> methods = [];

        internal CsClient HasMethod(CsMethod csMethod)
        {
            this.methods.Add(csMethod);

            return this;
        }

        internal override string ToString(string ns, CsContext csContext)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"namespace {ns}");
            stringBuilder.AppendLine($"{{");

            this.usings.Add("System");
            this.usings.Add("System.Threading.Tasks");

            var usingsList = this.usings
                .Where(x => !string.IsNullOrWhiteSpace(x))
                .ToHashSet()
                .OrderBy(x => x)
                .GroupBy(x => x[0])
                .ToDictionary(x => x.Key, x => x.ToList());

            foreach (var (_, usings) in usingsList)
            {
                foreach (var @using in usings)
                {
                    stringBuilder.AppendLine($"\tusing {@using};");
                }

                stringBuilder.AppendLine();
            }

            if (!string.IsNullOrWhiteSpace(this.description))
            {
                stringBuilder.AppendLine($"\t/// <summary>");

                foreach (var line in this.description.SplitToLines())
                {
                    stringBuilder.AppendLine($"\t/// {line}");
                }

                stringBuilder.AppendLine($"\t/// </summary>");
            }

            foreach (var (attr, val) in this.attributes)
            {
                if (string.IsNullOrWhiteSpace(val))
                {
                    stringBuilder.AppendLine($"\t[{attr}]");
                }
                else
                {
                    stringBuilder.AppendLine($"\t[{attr}({val.Replace("\\", "\\\\")})]");
                }
            }

            var inherits = $"{this.inherits}(baseAddress)" ?? "BaseClass";
            stringBuilder.AppendLine($"\tpublic class {this.name}(Uri baseAddress) : {inherits}");
            stringBuilder.AppendLine($"\t{{");

            var count = this.methods.Count;

            foreach (var method in this.methods)
            {
                foreach (var line in method.AsEnumerable())
                {
                    stringBuilder.AppendLine($"\t\t{line}");
                }

                if (--count > 0)
                {
                    stringBuilder.AppendLine();
                }
            }

            stringBuilder.AppendLine($"\t}}");
            stringBuilder.AppendLine($"}}");

            return stringBuilder.ToString();
        }
    }
}