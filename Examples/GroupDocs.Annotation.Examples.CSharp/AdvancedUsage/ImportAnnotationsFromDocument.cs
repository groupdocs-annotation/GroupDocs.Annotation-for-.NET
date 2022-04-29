using System;
using System.IO;
using GroupDocs.Annotation;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    class ImportAnnotationsFromDocument
    {
        public static void Run()
        {
            using (Annotator annotator = new Annotator("input.pdf-file")) // specify the path to the file with the annotated
            {
                annotator.ImportAnnotationsFromDocument("result.XML-file"); // specify the path to the result XML file
            }
        }
    }
}
