using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates adding search text fragment annotation.
    /// </summary>
    class AddSearchTextFragmentAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddSearchTextFragmentAnnotation : This example demonstrates adding text fragment annotation");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                SearchTextFragment searchText = new SearchTextFragment()
                {
                    Text = "Welcome to GroupDocs", //here should be the text that is contained in your document, otherwise nothing will be highlighted
                    FontSize = 10,
                    FontFamily = "Calibri",
                    FontColor = 65535,
                    BackgroundColor = 16761035,
                };
                annotator.Add(searchText);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
