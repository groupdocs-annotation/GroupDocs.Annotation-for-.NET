using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Saving
{
    using GroupDocs.Annotation;
    /// <summary>
    /// This example demonstrates saving result document as document given to create annotator class
    /// </summary>
    class SavingAsInputFromFilePath
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SavingAsInputFromFilePath : saving result document as document given to create annotator class");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                annotator.Save();
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
