using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates removing annotation from the document by annotation object.
    /// </summary>
    class RemoveAnnotationByAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveAnnotationByAnnotation : removing annotation from the document by annotation object.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                annotator.Remove(annotator.Get()[0]);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
