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

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                IDocumentInfo info = annotator.Document.GetDocumentInfo();
                if (info == null || info?.PageCount == 0)
                {
                    throw new Exception("Unexpected document information!");
                }
                Console.WriteLine($"\nFile type: {info.FileType}\nNumber of pages: {info.PageCount}\nDocument size: {info.Size} bytes.");
            }
            Console.WriteLine($"\nDocument info extracted successfully.");
        }
    }
}