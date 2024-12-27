using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates how to add image annotaion over the text
    /// </summary>
    class PutImageAnnotationOverText
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # PutImageAnnotationOverText : adding image annotaion over the text.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result_for_zIndex" + Path.GetExtension(Constants.INPUT_DOCX));

            using (Annotator annotator = new Annotator(Constants.INPUT_DOCX))
            {
                ImageAnnotation image = new ImageAnnotation
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    CreatedOn = DateTime.Now,
                    Opacity = 0.7,
                    PageNumber = 0,
                    ImagePath = Constants.PICTURE,
                    ZIndex = 3
                };
                annotator.Add(image);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
