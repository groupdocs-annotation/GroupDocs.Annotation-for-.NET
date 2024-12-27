using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Saving
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;
    /// <summary>
    /// This example demonstrates saving result document as document given to create annotator class
    /// </summary>
    class SavingAsInputFromFileStreamWithOptions
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SavingAsInputFromFileStreamWithOptions : saving result document as document given to create annotator class.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(),
                "result" + Path.GetExtension(Constants.INPUT_PDF));
            using (FileStream fs = new FileStream(Constants.INPUT_PDF, FileMode.Open))
            {
                using (Annotator annotator = new Annotator(fs))
                {
                    annotator.Save(new SaveOptions{ Version = Guid.NewGuid().ToString() });
                }
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
