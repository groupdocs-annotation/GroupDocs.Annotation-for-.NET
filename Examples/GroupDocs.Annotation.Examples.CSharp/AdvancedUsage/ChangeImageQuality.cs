using System;
using System.IO;
using GroupDocs.Annotation;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    class ChangeImageQuality
    {
        public static void Run()
        {
            using (Annotator annotator = new Annotator("input.pdf-file")) // specify the path to the input PDF file
{
	        string dataDir = "input.pdf"; // specify the path to the input PDF file
            string data = "image.jpg"; // the path to the JPG file
            int pageNumber = 1; // set the page where the image will be inserted
            int imageQuality = 10; // set image quality
            annotator.Document.AddImageToDocument(dataDir, data, pageNumber, imageQuality);
}
        }
    }
}
