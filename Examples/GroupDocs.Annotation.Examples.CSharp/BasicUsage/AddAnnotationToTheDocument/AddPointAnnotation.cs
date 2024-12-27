using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates adding point annotation.
    /// </summary>
    class AddPointAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddPointAnnotation : This example demonstrates adding point annotation");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                PointAnnotation point = new PointAnnotation
                {
                    Box = new Rectangle(100, 100, 0, 0),
                    CreatedOn = DateTime.Now,
                    Message = "This is point annotation",
                    PageNumber = 0,
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
                annotator.Add(point);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
