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

            using (Annotator annotator = new Annotator(Constants.INPUT))
            {
                IDocumentInfo info = annotator.Document.GetDocumentInfo();
                int width = info.PagesInfo[0].Width;
                int height = info.PagesInfo[0].Height;
            }
        }
    }
}
