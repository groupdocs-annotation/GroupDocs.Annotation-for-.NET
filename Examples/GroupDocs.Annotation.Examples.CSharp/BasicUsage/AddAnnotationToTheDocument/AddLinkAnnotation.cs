using System;
using System.Collections.Generic;
using System.IO;
using GroupDocs.Annotation.Models;
using GroupDocs.Annotation.Models.AnnotationModels;
using GroupDocs.Annotation.Options;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    /// <summary>
    /// This example demonstrates adding link annotation.
    /// </summary>
    class AddLinkAnnotation
    {
        public static void Run()
        {
            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator(Constants.INPUT))
            {
                LinkAnnotation link = new LinkAnnotation
                {
                    CreatedOn = DateTime.Now,
                    Message = "This is link annotation",
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
                    },
                    Url = "https://www.google.com"
                };
                annotator.Add(link);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
