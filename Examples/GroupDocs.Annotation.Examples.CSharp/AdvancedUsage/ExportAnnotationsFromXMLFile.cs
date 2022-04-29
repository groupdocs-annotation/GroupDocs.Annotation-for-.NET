using System;
using System.IO;
using GroupDocs.Annotation;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    class ExportAnnotationsFromXMLFile
    {
        public static void Run()
        {
            using (Annotator annotator = new Annotator("input.pdf-file")) // specify the path to the input PDF file
{
	        annotator.ExportAnnotationsFromXMLFile("input.XML-file"); // specify the path to the input XML file
            annotator.Save("result_export");
}
        }
    }
}
