using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates adding watermark annotation.
    /// </summary>
    class AddWatermarkAnnotation
    {
        public static void Run()
        {
            Console.WriteLine("\n---------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddWatermarkAnnotation : This example demonstrates adding watermark annotation");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                WatermarkAnnotation watermark = new WatermarkAnnotation
                {
                    Angle = 75,
                    Box = new Rectangle(200, 200, 100, 50),
                    CreatedOn = DateTime.Now,
                    Text = "Watermark",
                    FontColor = 65535,
                    FontSize = 12,
                    Message = "This is watermark annotation",
                    Opacity = 0.7,
                    PageNumber = 0,
                    AutoScale = true,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    VerticalAlignment = VerticalAlignment.Center,
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
                annotator.Add(watermark);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
