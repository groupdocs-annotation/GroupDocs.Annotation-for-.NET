using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates how to remove annotations from annotated document by Id
    /// </summary>
    class RemoveAnnotationById
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveAnnotationById : remove annotations from annotated document by Id.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                annotator.Remove(0);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }

    }
}
