using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;    
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates adding replies to annotation.
    /// </summary>
    class AddReplies
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # AddReplies : adding replies to annotation.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                User user1 = new User
                {
                    Id = 1,
                    Name = "Tom",
                    Email = "somemail@mail.com"
                };
                User user2 = new User
                {
                    Id = 2,
                    Name = "Jack",
                    Email = "somebody@mail.com"
                };
                AreaAnnotation area = new AreaAnnotation
                {
                    BackgroundColor = 65535,
                    Box = new Rectangle(100, 100, 100, 100),
                    CreatedOn = DateTime.Now,
                    Message = "This is area annotation",
                    Opacity = 0.7,
                    PageNumber = 0,
                    PenColor = 65535,
                    PenStyle = PenStyle.Dot,
                    PenWidth = 3,
                    Replies = new List<Reply>
                    {
                        new Reply
                        {
                            Id = 1,
                            Comment = "First comment",
                            RepliedOn = DateTime.Now,
                            User = user1
                        },
                        new Reply
                        {
                            Id = 2,
                            Comment = "Second comment",
                            RepliedOn = DateTime.Now,
                            User = user2,
                        },
                        new Reply
                        {
                            Id = 3,
                            Comment = "Third comment",
                            RepliedOn = DateTime.Now,
                            User = user1
                        },
                        new Reply
                        {
                            Id = 4,
                            Comment = "Fourth comment",
                            RepliedOn = DateTime.Now,
                            User = user2
                        }
                    }
                };
                annotator.Add(area);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
