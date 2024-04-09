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
    /// This example demonstrates saving result document with specified annotations
    /// </summary>
    class FilteringAnnotationTypes
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # FilteringAnnotationTypes : saving result document with specified annotations.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator(Constants.INPUT))
            {
                AreaAnnotation area = new AreaAnnotation()
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 65535,
                    PageNumber = 0
                };
                EllipseAnnotation ellipse = new EllipseAnnotation()
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 123456,
                    PageNumber = 1
                };
                annotator.Add(new List<AnnotationBase>() { area, ellipse });
                annotator.Save(outputPath, new SaveOptions { AnnotationTypes = AnnotationType.Ellipse});
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
