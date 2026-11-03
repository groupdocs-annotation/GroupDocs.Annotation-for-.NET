using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates adding annotations stored in an XML file to a document.
    /// </summary>
    class ExportAnnotationsFromXMLFile
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # ExportAnnotationsFromXMLFile : adding annotations stored in an XML file to a document.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                annotator.ExportAnnotationsFromXMLFile(Constants.ANNOTATIONS_XML);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
