using System;
using System.IO;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;    
    using GroupDocs.Annotation.Models.AnnotationModels;    

    /// <summary>
    /// This example demonstrates how to extract annotations
    /// </summary>
    class ExtractAnnotationsFromDocument
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # ExtractAnnotationsFromDocument : how to extract annotations.");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "annotation.xml");

            using (Annotator annotator = new Annotator(Constants.ANNOTATED))
            {
                var annotations = annotator.Get();
                XmlSerializer formatter = new XmlSerializer(typeof(List<AnnotationBase>));
                using (FileStream fs = new FileStream(outputPath, FileMode.Create))
                {
                    fs.SetLength(0);
                    formatter.Serialize(fs, annotations);
                }
            }
            Console.WriteLine($"\nAnnotations extracted to annotation.xml file successfully.\nCheck output in {outputPath}.");
        }
    }
}
