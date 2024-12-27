using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates adding text highlight annotation.
    /// </summary>
    class AddTextHighlightAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddTextHighlightAnnotation : This example demonstrates adding text highlight annotation");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_DOCX));

            using (Annotator annotator = new Annotator(Constants.INPUT_DOCX))
            {
                try
                {
                    HighlightAnnotation highlight = new HighlightAnnotation
                    {
                        BackgroundColor = 65535,
                        CreatedOn = DateTime.Now,
                        FontColor = 0,
                        Message = "This is highlight annotation",
                        Opacity = 0.5,
                        PageNumber = 0,
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
                    annotator.Add(highlight);
                    annotator.Save(outputPath);
                }
                catch(Exception ex)
                {
                    if (ex.Message.Contains("trial mode"))
                    {
                        Helper.WriteError("\nThis example requires license to properly run. " +
                                      "\nVisit the GroupDocs site to obtain either a temporary or permanent license. " +
                                      "\nLearn more about licensing at https://purchase.groupdocs.com/faqs/licensing. " +
                                      "\nLearn how to request temporary license at https://purchase.groupdocs.com/temporary-license.");
                    }
                    else throw ex;
                }
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
