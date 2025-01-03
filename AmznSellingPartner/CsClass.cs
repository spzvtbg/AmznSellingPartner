namespace AmznSellingPartner
{
    using System.Linq;
    using System.Text;

    internal class CsClass(string name) : CsType(name)
    {
        internal override string ToString(string ns, CsContext csContext)
        {
            var stringBuilder = new StringBuilder();

            stringBuilder.AppendLine($"namespace {ns}");
            stringBuilder.AppendLine($"{{");

            var usingsList = this.usings
                .Union(this.properties.Values
                .SelectMany(x => x.GetUsings()))
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

            stringBuilder.AppendLine($"\tpublic class {this.name} : {this.inherits ?? "BaseClass"}");
            stringBuilder.AppendLine($"\t{{");

            var count = this.properties.Values.Count;

            foreach (var property in this.properties.Values)
            {
                foreach (var line in property.AsEnumerable())
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