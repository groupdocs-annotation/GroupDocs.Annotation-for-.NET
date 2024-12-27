using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates how to remove annotations from document using SaveOptions Property
    /// </summary>
    class RemoveAnnotationUsingSaveOptions
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveAnnotationUsingSaveOptions : remove annotations from document using SaveOptions Property.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                annotator.Save(outputPath, new SaveOptions() { AnnotationTypes = AnnotationType.None });
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
