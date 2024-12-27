using System;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;    

    /// <summary>
    /// This example demonstrates getting document pages width and height
    /// </summary>
    class GettingSizeOfDocumentPage
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # GettingSizeOfDocumentPage : getting document pages width and height.");

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF))
            {
                IDocumentInfo info = annotator.Document.GetDocumentInfo();
                if (info.PagesInfo != null && info.PagesInfo.Count > 0)
                {
                    Console.WriteLine($"\t Document info: Type {info.FileType}, size = {info.Size}, pages = {info.PageCount}");
                    foreach( var page in info.PagesInfo ) 
                    {
                        Console.WriteLine($"\t\t page #{page.PageNumber}: {page.Width}x{page.Height}");
                    }
                }
            }
        }
    }
}
