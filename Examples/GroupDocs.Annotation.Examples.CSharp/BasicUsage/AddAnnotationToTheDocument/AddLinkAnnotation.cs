using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;    

    /// <summary>
    /// This example demonstrates adding link annotation.
    /// </summary>
    class AddLinkAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddLinkAnnotation : This example demonstrates adding link annotation");

            string inputPath = Constants.INPUT_DOCX;
            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), $"AddLinkAnnotation-output{Path.GetExtension(inputPath)}");

            using (Annotator annotator = new Annotator(inputPath))
            {
                try
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
