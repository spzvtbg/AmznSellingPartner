namespace AmznSellingPartner.BuildTools.Models
{
    using System.Configuration;
    using System.IO;

    public class AppSettings
    {
        public static readonly string CurrentDirectory
            = Path.GetDirectoryName(typeof(App).Assembly.Location);

        public static string SpModelsDirName
            => ConfigurationManager.AppSettings?["sp-models-dir"]
            ?? "selling-partner-api-models";

        public static string SpModelsGit
            => ConfigurationManager.AppSettings?["sp-models-git"]
            ?? "https://github.com/amzn/selling-partner-api-models.git";
    }
}
