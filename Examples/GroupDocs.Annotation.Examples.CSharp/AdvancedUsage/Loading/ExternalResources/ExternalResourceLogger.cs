using System;
using System.Collections.Generic;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading.ExternalResources
{
    using GroupDocs.Annotation.Options;

    /// <summary>
    /// Prints every external resource a document references and whether it is loaded or skipped.
    /// The decision is left exactly as LoadOptions made it.
    /// </summary>
    internal class ExternalResourceLogger : ExternalResourceHandler
    {
        private readonly HashSet<string> _reported = new HashSet<string>();

        public override void OnLoading(ExternalResourceLoadingArgs args)
        {
            // the same resource is reported once, although every operation (open, save, preview) asks again
            if (_reported.Add(args.Uri))
                Console.WriteLine($"  {(args.Skipped ? "skipped" : "loaded ")}  {args.Uri}");
        }
    }
}
