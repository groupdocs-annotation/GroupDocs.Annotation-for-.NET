using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading.ExternalResources
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates how to load every external resource a document references (the behaviour before 26.10).
    /// </summary>
    /// <remarks>
    /// Use it only for documents from a trusted source: a document can reference any address, including internal
    /// services reachable from your server.
    /// </remarks>
    internal class LoadAllExternalResources
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # LoadAllExternalResources : loading every external resource of a trusted document.");

            string outputDirectory = Constants.GetOutputDirectoryPath();

            LoadOptions loadOptions = new LoadOptions
            {
                SkipExternalResources = false,
                ExternalResourceHandler = new ExternalResourceLogger()
            };

            using (Annotator annotator = new Annotator(Constants.REMOTE_RESOURCES_EML, loadOptions))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                    File.Create(Path.Combine(outputDirectory, $"result_{pageNumber}.png")));
                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.PageNumbers = new int[] { 1 };

                annotator.Document.GeneratePreview(previewOptions);
            }
            Console.WriteLine($"\nDocument preview generated with all external resources.\nCheck output in {outputDirectory}.");
        }
    }
}
