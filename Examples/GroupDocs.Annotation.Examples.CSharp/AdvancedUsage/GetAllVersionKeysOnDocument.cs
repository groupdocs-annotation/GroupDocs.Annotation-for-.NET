using System;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates getting all version keys from document
    /// </summary>
    class GetAllVersionKeysOnDocument
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # GetAllVersionKeysOnDocument : getting all version keys from document.");


            using (Annotator annotator = new Annotator(Constants.ANNOTATED_WITH_VERSIONS))
            {
                List<object> versionKeys = annotator.GetVersionsList();
            }
        }
    }
}
