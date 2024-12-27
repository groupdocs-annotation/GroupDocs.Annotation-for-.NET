using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Saving
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates saving document version with custom versionKey
    /// </summary>
    class SavingDocumentVersionWithCustomName
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SavingDocumentVersionWithCustomName : saving document version with custom versionKey.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                AreaAnnotation area = new AreaAnnotation()
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 65535,
                    PageNumber = 1
                };
                EllipseAnnotation ellipse = new EllipseAnnotation()
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 123456,
                    PageNumber = 1
                };
                annotator.Add(new List<AnnotationBase>() { area, ellipse });
                annotator.Save(outputPath, new SaveOptions { Version = "SECOND" });
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
