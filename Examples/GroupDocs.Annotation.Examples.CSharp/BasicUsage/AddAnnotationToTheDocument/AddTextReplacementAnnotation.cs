using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;
    

    /// <summary>
    /// This example demonstrates adding text replacement annotation.
    /// </summary>
    class AddTextReplacementAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddTextReplacementAnnotation : This example demonstrates adding text replacement annotation");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator(Constants.INPUT))
            {
                ReplacementAnnotation replacement = new ReplacementAnnotation
                {
                    CreatedOn = DateTime.Now,
                    FontColor = Color.Blue.ToArgb(),
                    Message = "This is replacement annotation",
                    Opacity = 0.7,
                    PageNumber = 0,
                    BackgroundColor = Color.Red.ToArgb(),
                    Points = new List<Point>
                    {
                        new Point(80, 730), new Point(240, 730), new Point(80, 650), new Point(240, 650)
                    },
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
                    },
                    TextToReplace = "replaced text"
                };
                annotator.Add(replacement);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
