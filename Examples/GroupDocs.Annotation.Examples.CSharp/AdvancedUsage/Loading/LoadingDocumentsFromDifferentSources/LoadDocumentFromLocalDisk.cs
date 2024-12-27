using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates loading document from file path.
    /// </summary>
    class LoadDocumentFromLocalDisk
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # LoadDocumentFromLocalDisk : loading document from file path.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                AreaAnnotation area = new AreaAnnotation()
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 65535,
                };
                annotator.Add(area);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
