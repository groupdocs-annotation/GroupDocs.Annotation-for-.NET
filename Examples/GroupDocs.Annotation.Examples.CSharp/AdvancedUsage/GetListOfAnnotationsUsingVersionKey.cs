using System;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates getting list of annotations from document using version key
    /// </summary>
    class GetListOfAnnotationsUsingVersionKey
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # GetListOfAnnotationsUsingVersionKey : getting list of annotations from document using version key.");

            using (Annotator annotator = new Annotator(Constants.ANNOTATED_WITH_VERSIONS))
            {
                List<AnnotationBase> annotations = annotator.GetVersion("CUSTOM_VERSION");
            }
        }
    }
}
