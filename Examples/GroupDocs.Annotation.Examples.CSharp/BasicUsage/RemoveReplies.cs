using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates how to remove replies from annotated document
    /// </summary>
    class RemoveReplies
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveReplies : remove replies from annotated document.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            // NOTE: Input document already contain annotations with replies
            using (Annotator annotator = new Annotator(Constants.ANNOTATED_WITH_REPLIES))
            {
                // Obtain annotations collection from document
                List<AnnotationBase> annotations = annotator.Get();
                
                // Remove first reply by index
                annotations[0].Replies.RemoveAt(0);
                
                // Save changes
                annotator.Update(annotations);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }
    }
}
