using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Annotation.Models;
using GroupDocs.Annotation.Models.AnnotationModels;
using GroupDocs.Annotation.Options;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    /// <summary>
    /// This example demonstrates adding search text fragment annotation.
    /// </summary>
    class AddSearchTextFragmentAnnotation
    {
        public static void Run()
        {
            
            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator(Constants.INPUT))
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
