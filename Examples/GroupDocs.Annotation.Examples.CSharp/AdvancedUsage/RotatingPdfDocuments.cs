using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;

    /// <summary>
    /// This example demonstrates rotating a page of a PDF document.
    /// </summary>
    class RotatingPdfDocuments
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # RotatingPdfDocuments : rotating a page of a PDF document.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                annotator.ProcessPages = 1; // the page to rotate
                annotator.Rotation = RotationDocument.on90;
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nThe page is rotated 90 degrees.\nCheck output in {outputPath}.");
        }
    }
}
