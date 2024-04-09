using System;
using System.Linq;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.BasicUsage
{
    using GroupDocs.Annotation;

    /// <summary>
    /// This example demonstrates file types support
    /// </summary>
    class GetSupportedFileFormats
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Basic Usage] # GetSupportedFileFormats : file types support.");

            IEnumerable<FileType> fileTypes = FileType
                    .GetSupportedFileTypes()
                    .OrderBy(fileType => fileType.Extension);
            foreach (FileType fileType in fileTypes)
                Console.WriteLine(fileType);
            Console.WriteLine("\nSupported file types retrieved successfully.");
        }
    }
}