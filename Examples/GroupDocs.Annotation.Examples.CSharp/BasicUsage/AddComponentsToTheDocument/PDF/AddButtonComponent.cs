using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.FormatSpecificComponents.Pdf;

    /// <summary>
    /// This example demonstrates adding button component.
    /// </summary>
    class AddButtonComponent
    {
        /// <summary>
        /// Known issue for 24.4 version to fail without setting some property and leave as null value 
        /// Will be fixed with the nearest 24.5.
        /// </summary>
        public static void Run()
        {   
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddButtonComponent : adding button component");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            using (Annotator annotator = new Annotator(Constants.INPUT))
            {
                ButtonComponent button = new ButtonComponent
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    PenColor = 65535,
                    Style = BorderStyle.Dashed,
                    BorderWidth = 0,
                    BorderColor = 0,
                    AlternateName = "Name",
                    PartialName = "Patial Name",
                    NormalCaption = "Caption",
                    RolloverCaption = "Rollover",                    
                    ButtonColor = 16761035,
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
                annotator.Add(button);
                annotator.Save("result.pdf");
            }

            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
            /**/
        }
    }
}