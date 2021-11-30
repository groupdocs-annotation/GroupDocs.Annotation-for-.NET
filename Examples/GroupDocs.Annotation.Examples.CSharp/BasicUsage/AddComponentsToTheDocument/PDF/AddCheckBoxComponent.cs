using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Annotation.Models;
using GroupDocs.Annotation.Models.AnnotationModels;
using GroupDocs.Annotation.Models.FormatSpecificComponents.Pdf;
using GroupDocs.Annotation.Options;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    /// <summary>
    /// This example demonstrates adding checkBox component.
    /// </summary>
    class AddCheckBoxComponent
    {
        public static void Run()
        {
            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator("input.pdf"))
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