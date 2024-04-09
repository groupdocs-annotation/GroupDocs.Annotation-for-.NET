using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates generating preview of document without rendering comments
    /// </summary>
    class GeneratePreviewWithoutComments
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # GeneratePreviewWithoutComments : generating preview of document without rendering comments.");

            using (Annotator annotator = new Annotator(Constants.ANNOTATED_DOCX))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                {
                    var pagePath = $"result{pageNumber}.png";
                    return File.Create(pagePath);
                });
                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.PageNumbers = new int[] { 1, 2, 3, 4, 5, 6 };
                previewOptions.RenderComments = false;
                annotator.Document.GeneratePreview(previewOptions);
            }
        }
    }
}
