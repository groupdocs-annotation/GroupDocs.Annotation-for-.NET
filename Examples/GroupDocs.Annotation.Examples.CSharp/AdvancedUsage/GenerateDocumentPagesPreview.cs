using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;
    
    /// <summary>
    /// This example demonstrates annotating generating previews from document
    /// </summary>
    internal class GenerateDocumentPagesPreview
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # GenerateDocumentPagesPreview : annotating generating previews from document.");

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                {
                    var pagePath = Path.Combine(Constants.GetOutputDirectoryPath(), $"result_{pageNumber}.png");
                    return File.Create(pagePath);
                });
                previewOptions.PreviewFormat = PreviewFormats.PNG;

                previewOptions.PageNumbers = new int[] { 1, 2, 3, 4 };
                annotator.Document.GeneratePreview(previewOptions);
            }
            Console.WriteLine($"\nDocument previews generated successfully.\nCheck output in {Constants.GetOutputDirectoryPath()}.");
        }
    }
}