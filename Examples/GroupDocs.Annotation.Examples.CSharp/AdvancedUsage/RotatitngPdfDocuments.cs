using System;
using System.IO;
using GroupDocs.Annotation.Options;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    class SetDocumentPreviewResolution
    {
        public static void Run()
        {
            using (Annotator annotator = new Annotator("input.pdf"))
            {
                annotator.ProcessPages = 1;
                annotator.Rotation = RotationDocument.on90;
                annotator.Save("result.pdf");
            }

            Console.WriteLine($"\nThe document is rotated 90 degrees");
        }
    }
}
