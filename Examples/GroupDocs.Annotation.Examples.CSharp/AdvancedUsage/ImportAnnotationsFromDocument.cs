using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates writing the annotations of a document to an XML file.
    /// </summary>
    class ImportAnnotationsFromDocument
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # ImportAnnotationsFromDocument : writing document annotations to an XML file.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result.xml");

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                annotator.ImportAnnotationsFromDocument(outputPath);
            }
            Console.WriteLine($"\nAnnotations saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
