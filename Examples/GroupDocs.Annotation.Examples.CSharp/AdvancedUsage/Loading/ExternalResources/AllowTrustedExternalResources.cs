using System;
using System.Collections.Generic;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading.ExternalResources
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates how to load external resources only from trusted locations.
    /// </summary>
    /// <remarks>
    /// An entry of <see cref="LoadOptions.WhitelistedResources"/> is either a host name (matches the host and its subdomains,
    /// for example "cdn.example.com") or an absolute URI prefix (scheme, host and port must match, the path matches on
    /// a segment boundary). Everything else stays skipped.
    /// </remarks>
    internal class AllowTrustedExternalResources
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # AllowTrustedExternalResources : loading external resources from trusted locations only.");

            string outputDirectory = Constants.GetOutputDirectoryPath();

            LoadOptions loadOptions = new LoadOptions
            {
                // SkipExternalResources stays true (the default); only the listed locations are loaded
                WhitelistedResources = new List<string> { "https://raw.githubusercontent.com/groupdocs-annotation/" },
                ExternalResourceHandler = new ExternalResourceLogger()
            };

            using (Annotator annotator = new Annotator(Constants.REMOTE_RESOURCES_HTML, loadOptions))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                    File.Create(Path.Combine(outputDirectory, $"result_{pageNumber}.png")));
                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.PageNumbers = new int[] { 1 };

                annotator.Document.GeneratePreview(previewOptions);
            }
            Console.WriteLine($"\nDocument preview generated with trusted external resources only.\nCheck output in {outputDirectory}.");
        }
    }
}
