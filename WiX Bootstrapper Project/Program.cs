using System;
using WixSharp;
using WixSharp.Bootstrapper;

namespace WiX_Bootstrapper_Project
{
    public class Program
    {
        static void Main()
        {
            string productMsi = BuildMsi();

            var bootstrapper =
              new Bundle("MyProduct",
                  new PackageGroupRef("NetFx462Web"),
                  new MsiPackage(productMsi) { DisplayInternalUI = true });

            bootstrapper.Version = new Version("1.0.0.0");
            bootstrapper.UpgradeCode = new Guid("9581aded-d6fc-4f41-9543-0a407b069d30");
            // bootstrapper.PreserveTempFiles = true;

            bootstrapper.Build("MyProduct.exe");
        }

        static string BuildMsi()
        {
            var project = new Project("MyProduct",
                             new Dir(@"%ProgramFiles%\My Company\My Product",
                                 new File("Program.cs")));

            project.GUID = new Guid("9581aded-d6fc-4f41-9543-0a407b069d30");
            //project.SourceBaseDir = "<input dir path>";
            //project.OutDir = "<output dir path>";

            return project.BuildMsi();
        }
    }
}