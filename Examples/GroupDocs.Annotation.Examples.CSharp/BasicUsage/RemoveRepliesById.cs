using System;
using System.IO;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;    
    using GroupDocs.Annotation.Models.AnnotationModels;
    
    /// <summary>
    /// This example demonstrates how to remove replies from annotated document by reply Id
    /// </summary>
    class RemoveRepliesById
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # RemoveRepliesById : remove replies from annotated document by reply Id.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT_PDF));

            // NOTE: Input document already contain annotations with replies
            using (Annotator annotator = new Annotator(Constants.ANNOTATED_WITH_REPLIES))
            {
                // Obtain annotations collection from document
                List<AnnotationBase> annotations = annotator.Get();

                // Remove reply with Id = 4
                annotations[0].Replies.RemoveAll(x => x.Id == 4);

                // Save changes
                annotator.Update(annotations);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");            
        }
    }
}
