using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;    
    using GroupDocs.Annotation.Models.FormatSpecificComponents.Pdf;

    /// <summary>
    /// This example demonstrates adding checkBox component.
    /// </summary>
    class AddCheckBoxComponent
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddCheckBoxComponent : adding checkBox component.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                CheckBoxComponent checkBox = new CheckBoxComponent
                {
                    Checked = true,
                    Box = new Rectangle(100, 100, 100, 100),
                    PenColor = 65535,
                    Style = BoxStyle.Star,
                    Replies = new List<Reply>
                        {
                            new Reply
                            {
                                Comment = "First comment",
                                RepliedOn = DateTime.Now
                            },
                            new Reply
                            {
                                Comment = "Second comment",
                                RepliedOn = DateTime.Now
                            }
                        }
                };
                annotator.Add(checkBox);
                annotator.Save("result.pdf");
            }

            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}