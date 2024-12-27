using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage.AddAnnotationToTheDocument
{
    using GroupDocs.Annotation;    
    using GroupDocs.Annotation.Models;    
    using GroupDocs.Annotation.Models.FormatSpecificComponents.Pdf;

    /// <summary>
    /// This example demonstrates adding dropdown component.
    /// </summary>
    class AddDropdownComponent
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddDropdownComponent : adding dropdown component.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                DropdownComponent dropdown = new DropdownComponent
                {
                    Options = new List<string> { "Item1", "Item2", "Item3" },
                    SelectedOption = null,
                    Placeholder = "Choose option",
                    Box = new Rectangle(100, 100, 100, 100),
                    CreatedOn = DateTime.Now,
                    Message = "This is dropdown component",
                    PageNumber = 0,
                    PenColor = 65535,
                    PenStyle = PenStyle.Dot,
                    PenWidth = 3,
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
                annotator.Add(dropdown);
                annotator.Save("result.pdf");
            }

            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}