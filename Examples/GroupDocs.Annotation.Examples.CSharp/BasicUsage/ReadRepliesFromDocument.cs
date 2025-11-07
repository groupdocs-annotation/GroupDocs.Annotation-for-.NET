using System;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates how to enumerate replies from existing annotations.
    /// </summary>
    internal class ReadRepliesFromDocument
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # ReadRepliesFromDocument : reading annotation replies from annotated document.");

            using (Annotator annotator = new Annotator(Constants.ANNOTATED_WITH_REPLIES))
            {
                List<AnnotationBase> annotations = annotator.Get();

                if (annotations.Count == 0)
                {
                    Console.WriteLine("\nNo annotations found in the document.");
                    return;
                }

                foreach (AnnotationBase annotation in annotations)
                {
                    if (annotation.Replies == null || annotation.Replies.Count == 0)
                    {
                        continue;
                    }

                    string replyWord = annotation.Replies.Count == 1 ? "reply" : "replies";
                    Console.WriteLine($"\nAnnotation #{annotation.Id} on page {annotation.PageNumber + 1} has {annotation.Replies.Count} {replyWord}:");

                    foreach (Reply reply in annotation.Replies)
                    {
                        string userName = reply.User?.Name ?? "Unknown user";
                        Console.WriteLine($" - [{reply.RepliedOn:G}] {userName}: {reply.Comment}");
                    }
                }
            }

            Console.WriteLine("\nAnnotation replies processed successfully.");
        }
    }
}

