using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Saving
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates saving result document as document given to create annotator class
    /// </summary>
    class SavingAsInputFromFilePathWithOptions
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # SavingAsInputFromFilePathWithOptions : saving result document as document given to create annotator class.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            // the document is saved over the file it was opened from, so work on a copy of the sample
            File.Copy(Constants.INPUT_PDF, outputPath, true);

            using (Annotator annotator = new Annotator(outputPath))
            {
                annotator.Save(new SaveOptions { Version = Guid.NewGuid().ToString() });
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
