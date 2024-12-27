using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates generating preview with specifix preview image resolutions
    /// </summary>
    class SetDocumentPreviewResolution
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SetDocumentPreviewResolution : generating preview with specifix preview image resolutions.");

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                {
                    var pagePath = Path.Combine(Constants.GetOutputDirectoryPath(), $"result_with_resolution_{pageNumber}.png");
                    return File.Create(pagePath);
                });

                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.Resolution = 144;

                annotator.Document.GeneratePreview(previewOptions);
            }

            Console.WriteLine($"\nDocument preview with resolution generated successfully.\nCheck output in {Constants.GetOutputDirectoryPath()}.");
        }
    }
}
