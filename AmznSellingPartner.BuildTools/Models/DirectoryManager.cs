namespace AmznSellingPartner.BuildTools.Models
{
    using System.Configuration;
    using System.IO;

    public class DirectoryManager
    {
        private readonly string spModelsGit;
        private readonly string spModelsDir;
        private readonly string spModelsSln;

        public DirectoryManager()
        {
            this.spModelsDir = ConfigurationManager.AppSettings["sp-models-dir"];
            this.spModelsGit = ConfigurationManager.AppSettings["sp-models-git"];
            this.spModelsSln = ConfigurationManager.AppSettings["sp-models-sln"];

            if (!Directory.Exists(this.spModelsDir))
            {
                Directory.CreateDirectory(this.spModelsDir);
            }
        }
    }
}
