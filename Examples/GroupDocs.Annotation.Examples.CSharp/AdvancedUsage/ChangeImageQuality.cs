using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates adding a JPG image with the specified quality to a PDF document page.
    /// </summary>
    class ChangeImageQuality
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # ChangeImageQuality : adding a JPG image with the specified quality to a PDF page.");

            // AddImageToDocument updates the PDF file in place, so work on a copy
            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));
            File.Copy(Constants.INPUT_PDF, outputPath, true);

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                int pageNumber = 1;    // the page where the image is inserted
                int imageQuality = 10; // from 1 (the smallest size) to 100 (the best quality)
                annotator.Document.AddImageToDocument(outputPath, Constants.SAMPLE_IMAGE_JPG, pageNumber, imageQuality);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
