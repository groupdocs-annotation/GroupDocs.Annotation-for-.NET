using System;
using System.Collections.Generic;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading.ExternalResources
{
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// This example demonstrates how to decide on every external resource in code: allow it, skip it,
    /// or provide its content from a local copy instead of the network.
    /// </summary>
    internal class ProvideExternalResourcesWithHandler
    {
        /// <summary>
        /// Serves a known remote picture from a local file and keeps everything else skipped.
        /// </summary>
        private class LocalCopyResourceHandler : ExternalResourceHandler
        {
            private const string BannerUri = "https://example.com/images/banner.png";
            private readonly HashSet<string> _reported = new HashSet<string>();

            public override void OnLoading(ExternalResourceLoadingArgs args)
            {
                // args.Skipped is pre-set from SkipExternalResources and WhitelistedResources
                if (args.Uri == BannerUri)
                {
                    // when Data is set nothing is requested; the document uses these bytes
                    args.Data = File.ReadAllBytes(Constants.SAMPLE_IMAGE);
                }

                // every operation (open, save, preview) asks again; report each resource once
                if (_reported.Add(args.Uri))
                    Console.WriteLine($"  {(args.Data != null ? "local copy" : args.Skipped ? "skipped   " : "loaded    ")}  {args.Uri}");
            }
        }

        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # ProvideExternalResourcesWithHandler : allowing, skipping or substituting each external resource.");

            string outputDirectory = Constants.GetOutputDirectoryPath();

            LoadOptions loadOptions = new LoadOptions { ExternalResourceHandler = new LocalCopyResourceHandler() };

            using (Annotator annotator = new Annotator(Constants.REMOTE_RESOURCES_DOCX, loadOptions))
            {
                PreviewOptions previewOptions = new PreviewOptions(pageNumber =>
                    File.Create(Path.Combine(outputDirectory, $"result_{pageNumber}.png")));
                previewOptions.PreviewFormat = PreviewFormats.PNG;
                previewOptions.PageNumbers = new int[] { 1 };

                annotator.Document.GeneratePreview(previewOptions);
            }
            Console.WriteLine($"\nDocument preview generated with a local copy of the remote picture.\nCheck output in {outputDirectory}.");
        }
    }
}
