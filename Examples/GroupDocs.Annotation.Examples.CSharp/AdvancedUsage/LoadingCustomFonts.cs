using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates working with custom font folder for the document processing
    /// </summary>
    class LoadingCustomFonts
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # LoadingCustomFonts : working with custom font folder for the document processing.");


            using (Annotator annotator = new Annotator(Constants.INPUT_WITH_CUSTOM_FONT, new LoadOptions { FontDirectories = new List<string> { Constants.GetFontDirectory() } }))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                {
                    var pagePath = Path.Combine(Constants.GetOutputDirectoryPath(), $"result_with_font_{pageNumber}.png");
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
