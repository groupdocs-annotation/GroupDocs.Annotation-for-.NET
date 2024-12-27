using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models.AnnotationModels;
    
    /// <summary>
    /// This example demonstrates removing document annotations by the list of annotations.
    /// </summary>
    class RemoveAnnotationsByAnnotations
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveAnnotationsByAnnotations : removing document annotations by the list of annotations.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                List<AnnotationBase> annotations = annotator.Get();
                annotator.Remove(annotations);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
