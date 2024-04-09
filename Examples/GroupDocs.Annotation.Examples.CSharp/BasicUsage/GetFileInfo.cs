using System;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates document info extraction
    /// </summary>
    class GetFileInfo
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # GetFileInfo : document info extraction.");

            using (Annotator annotator = new Annotator(Constants.INPUT))
            {
                IDocumentInfo info = annotator.Document.GetDocumentInfo();
                Console.WriteLine("\nFile type: {0}\nNumber of pages: {1}\nDocument size: {2} bytes", info.FileType, info.PageCount, info.Size);
            }
            Console.WriteLine($"\nDocument info extracted successfully.");
        }
    }
}