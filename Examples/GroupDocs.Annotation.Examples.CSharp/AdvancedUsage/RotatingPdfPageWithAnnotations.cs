using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates annotating a page of a PDF document and rotating the same page by 90 degrees.
    /// </summary>
    class RotatingPdfPageWithAnnotations
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # RotatingPdfPageWithAnnotations : annotating a page of a PDF document and rotating it by 90 degrees.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                annotator.Add(new AreaAnnotation
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 65535,
                    Message = "This is area annotation",
                    PageNumber = 0
                });
                annotator.Add(new PointAnnotation
                {
                    Box = new Rectangle(150, 150, 0, 0),
                    Message = "This is point annotation",
                    PageNumber = 0
                });

                annotator.ProcessPages = 1; // the page to rotate
                annotator.Rotation = RotationDocument.on90;
                annotator.Save(outputPath);
            }

            using (Annotator annotator = new Annotator(outputPath))
            {
                Console.WriteLine($"\nThe page is rotated 90 degrees, annotations in the document: {annotator.Get().Count}.");
            }
            Console.WriteLine($"Check output in {outputPath}.");
        }
    }
}
