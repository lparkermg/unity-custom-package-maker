// <copyright file="Program.cs" company="Luke Parker">
// Copyright (c) Luke Parker 2018.
// </copyright>

namespace UnityPackageMaker
{
    using System;
    using System.IO;
    using Newtonsoft.Json;

    /// <summary>
    /// Main Program.
    /// </summary>
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Unity Package Maker by Luke Parker");
            Console.WriteLine("This populates and produces a package-manifest.json file for making unity packages.\n");
            Console.WriteLine("===============================================================");

            var manifest = PopulateManifest();

            if (File.Exists("package-manifest.json"))
            {
                Console.Write("package-manifest.json already exists, do you wish to overwrite it [y/n]? ");
                var result = Console.ReadKey();
                if (result.KeyChar == 'n')
                {
                    Console.WriteLine("\nNo selected, file not saved.");
                    Console.ReadLine();
                    return;
                }
            }

            Console.WriteLine("\nAttempting to write file.");
            using (var fs = new FileStream("package-manifest.json", FileMode.Create, FileAccess.ReadWrite, FileShare.None))
            {
                using (var sw = new StreamWriter(fs))
                {
                    sw.Write(JsonConvert.SerializeObject(manifest));
                }
            }

            Console.WriteLine("The json file has been generated in the same directory as this application.");
            Console.ReadLine();
            return;
        }

        private static PackageManifest PopulateManifest()
        {
            Console.WriteLine("First what is the name of the package (i.e com.{CompanyName}.{PackageName})? ");
            var name = Console.ReadLine();

            Console.WriteLine("What about the Display Name? ");
            var displayName = Console.ReadLine();

            Console.WriteLine("What's the version of the package (X.X.X)? ");
            var version = Console.ReadLine();

            Console.WriteLine("What about the minimum unity version supported? ");
            var unityVersion = Console.ReadLine();

            Console.WriteLine("What's the description of the package? ");
            var description = Console.ReadLine();

            Console.WriteLine("What keywords are associated with the package (use , to seperate phrases)? ");
            var keywords = Console.ReadLine().Split(',');

            Console.WriteLine("What is the category of your package? ");
            var category = Console.ReadLine();

            return new PackageManifest()
            {
                Category = category,
                Description = description,
                DisplayName = displayName,
                Keywords = keywords,
                Name = name,
                Unity = unityVersion,
                Version = version
            };
        }
    }
}
