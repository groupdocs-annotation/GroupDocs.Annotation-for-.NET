using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates adding text strikeout annotation.
    /// </summary>
    class AddTextStrikeoutAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddTextStrikeoutAnnotation : This example demonstrates adding text strikeout annotation");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_DOCX));

            using (Annotator annotator = new Annotator(Constants.INPUT_DOCX))
            {
                StrikeoutAnnotation strikeout = new StrikeoutAnnotation
                {
                    CreatedOn = DateTime.Now,
                    FontColor = 65535,
                    Message = "This is strikeout annotation",
                    Opacity = 0.7,
                    PageNumber = 0,
                    BackgroundColor = 16761035,
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
                    }
                };
                annotator.Add(strikeout);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
