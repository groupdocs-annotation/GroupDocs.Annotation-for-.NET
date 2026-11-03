using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading.ExternalResources
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates that external resources (remote images, style sheets, linked files)
    /// referenced by a document are not loaded by default.
    /// </summary>
    /// <remarks>
    /// Since 26.10 <see cref="LoadOptions.SkipExternalResources"/> is true by default: opening, previewing or saving
    /// the document makes no network or file-share request. Skipped images are rendered as empty placeholders.
    /// </remarks>
    internal class SkipExternalResources
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SkipExternalResources : external resources are not loaded by default.");

            string outputDirectory = Constants.GetOutputDirectoryPath();

            // the logger only reports what happens; the default SkipExternalResources = true makes the decision
            LoadOptions loadOptions = new LoadOptions { ExternalResourceHandler = new ExternalResourceLogger() };

            using (Annotator annotator = new Annotator(Constants.REMOTE_RESOURCES_DOCX, loadOptions))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                    File.Create(Path.Combine(outputDirectory, $"result_{pageNumber}.png")));
                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.PageNumbers = new int[] { 1 };

                annotator.Document.GeneratePreview(previewOptions);
            }
            Console.WriteLine($"\nDocument preview generated without loading external resources.\nCheck output in {outputDirectory}.");
        }
    }
}
