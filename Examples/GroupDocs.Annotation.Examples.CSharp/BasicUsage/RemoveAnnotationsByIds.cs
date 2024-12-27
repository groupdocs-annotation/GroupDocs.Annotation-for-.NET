using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates removing document annotations by known list of annotations Identifiers (Ids).
    /// </summary>
    class RemoveAnnotationsByIds
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveAnnotationsByIds : removing document annotations by known list of annotations Identifiers (Ids).");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                annotator.Remove(new List<int>{0,1});
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
