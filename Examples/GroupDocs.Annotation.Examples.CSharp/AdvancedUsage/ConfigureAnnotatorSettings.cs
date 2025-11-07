using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Cache;
    using GroupDocs.Annotation.Logging;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates how to configure annotator settings with caching and logging.
    /// </summary>
    internal class ConfigureAnnotatorSettings
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # ConfigureAnnotatorSettings : using custom cache and logger when generating previews.");

            string outputDirectory = Constants.GetOutputDirectoryPath();
            string cacheDirectory = Path.Combine(outputDirectory, "cache");

            if (!Directory.Exists(cacheDirectory))
            {
                Directory.CreateDirectory(cacheDirectory);
            }

            AnnotatorSettings settings = new AnnotatorSettings
            {
                Cache = new FileCache(cacheDirectory),
                Logger = new ConsoleLogger()
            };

            using (Annotator annotator = new Annotator(Constants.INPUT_PDF, settings))
            {
                PreviewOptions previewOptions = new PreviewOptions(
                    pageNumber => new FileStream(Path.Combine(outputDirectory, $"settings_preview_{pageNumber}.png"), FileMode.Create),
                    (pageNumber, stream) => stream.Dispose());

                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.RenderAnnotations = true;
                previewOptions.RenderComments = true;
                previewOptions.PageNumbers = new[] { 1, 2 };
                previewOptions.Resolution = 144;

                annotator.Document.GeneratePreview(previewOptions);
            }

            Console.WriteLine($"\nPreviews generated with configured settings. Check output in {outputDirectory}.");
        }
    }
}

