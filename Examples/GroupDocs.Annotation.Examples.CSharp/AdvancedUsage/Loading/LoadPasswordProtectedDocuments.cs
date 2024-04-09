using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;
    
    /// <summary>
    /// This example demonstrates annotating documents that are protected with a password.
    /// </summary>
    class LoadPasswordProtectedDocuments
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # LoadPasswordProtectedDocuments : annotating documents that are protected with a password.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            LoadOptions loadOptions = new LoadOptions() { Password = "1234" };
            using (Annotator annotator = new Annotator(Constants.INPUT_PROTECTED, loadOptions))
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
