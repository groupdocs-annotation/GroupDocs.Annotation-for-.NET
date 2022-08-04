using GroupDocs.Annotation.MVC.Products.Common.Config;
using GroupDocs.Annotation.MVC.Products.Common.Util.Parser;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;

namespace GroupDocs.Annotation.MVC.Products.Annotation.Config
{
    /// <summary>
    /// AnnotationConfiguration.
    /// </summary>
    public class AnnotationConfiguration : CommonConfiguration
    {
        [JsonProperty]
        private readonly string filesDirectory = "DocumentSamples/Annotation";

        [JsonProperty]
        private readonly string defaultDocument = string.Empty;

        [JsonProperty]
        private readonly int preloadPageCount;

        [JsonProperty]
        private readonly bool textAnnotation = true;

        [JsonProperty]
        private readonly bool areaAnnotation = true;

        [JsonProperty]
        private readonly bool pointAnnotation = true;

        [JsonProperty]
        private readonly bool textStrikeoutAnnotation = true;

        [JsonProperty]
        private readonly bool polylineAnnotation = true;

        [JsonProperty]
        private readonly bool textFieldAnnotation = true;

        [JsonProperty]
        private readonly bool watermarkAnnotation = true;

        [JsonProperty]
        private readonly bool textReplacementAnnotation = true;

        [JsonProperty]
        private readonly bool arrowAnnotation = true;

        [JsonProperty]
        private readonly bool textRedactionAnnotation = true;

        [JsonProperty]
        private readonly bool resourcesRedactionAnnotation = true;

        [JsonProperty]
        private readonly bool textUnderlineAnnotation = true;

        [JsonProperty]
        private readonly bool distanceAnnotation = true;

        [JsonProperty]
        private readonly bool downloadOriginal = true;

        [JsonProperty]
        private readonly bool downloadAnnotated = true;

        [JsonProperty]
        private readonly bool zoom = true;

        /// <summary>
        /// Initializes a new instance of the <see cref="AnnotationConfiguration"/> class.
        /// Get Annotation configuration section from the Web.config.
        /// </summary>
        public AnnotationConfiguration()
        {
            YamlParser parser = new YamlParser();
            dynamic configuration = parser.GetConfiguration("annotation");
            ConfigurationValuesGetter valuesGetter = new ConfigurationValuesGetter(configuration);

            this.filesDirectory = valuesGetter.GetStringPropertyValue("filesDirectory", this.filesDirectory);
            if (!IsFullPath(this.filesDirectory))
            {
                this.filesDirectory = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, this.filesDirectory);
                if (!Directory.Exists(this.filesDirectory))
                {
                    Directory.CreateDirectory(this.filesDirectory);
                }
            }

            this.defaultDocument = valuesGetter.GetStringPropertyValue("defaultDocument", this.defaultDocument).Replace(@"\", "/");
            this.textAnnotation = valuesGetter.GetBooleanPropertyValue("textAnnotation", this.textAnnotation);
            this.areaAnnotation = valuesGetter.GetBooleanPropertyValue("areaAnnotation", this.areaAnnotation);
            this.pointAnnotation = valuesGetter.GetBooleanPropertyValue("pointAnnotation", this.pointAnnotation);
            this.textStrikeoutAnnotation = valuesGetter.GetBooleanPropertyValue("textStrikeoutAnnotation", this.textStrikeoutAnnotation);
            this.polylineAnnotation = valuesGetter.GetBooleanPropertyValue("polylineAnnotation", this.polylineAnnotation);
            this.textFieldAnnotation = valuesGetter.GetBooleanPropertyValue("textFieldAnnotation", this.textFieldAnnotation);
            this.watermarkAnnotation = valuesGetter.GetBooleanPropertyValue("watermarkAnnotation", this.watermarkAnnotation);
            this.textReplacementAnnotation = valuesGetter.GetBooleanPropertyValue("textReplacementAnnotation", this.textReplacementAnnotation);
            this.arrowAnnotation = valuesGetter.GetBooleanPropertyValue("arrowAnnotation", this.arrowAnnotation);
            this.textRedactionAnnotation = valuesGetter.GetBooleanPropertyValue("textRedactionAnnotation", this.textRedactionAnnotation);
            this.resourcesRedactionAnnotation = valuesGetter.GetBooleanPropertyValue("resourcesRedactionAnnotation", this.resourcesRedactionAnnotation);
            this.textUnderlineAnnotation = valuesGetter.GetBooleanPropertyValue("textUnderlineAnnotation", this.textUnderlineAnnotation);
            this.distanceAnnotation = valuesGetter.GetBooleanPropertyValue("distanceAnnotation", this.distanceAnnotation);
            this.downloadOriginal = valuesGetter.GetBooleanPropertyValue("downloadOriginal", this.downloadOriginal);
            this.downloadAnnotated = valuesGetter.GetBooleanPropertyValue("downloadAnnotated", this.downloadAnnotated);
            this.preloadPageCount = valuesGetter.GetIntegerPropertyValue("preloadPageCount", this.preloadPageCount);
            this.zoom = valuesGetter.GetBooleanPropertyValue("zoom", this.zoom);
        }

        public string GetFilesDirectory()
        {
            return this.filesDirectory;
        }

        public int GetPreloadPageCount()
        {
            return this.preloadPageCount;
        }

        private static bool IsFullPath(string path)
        {
            return !string.IsNullOrWhiteSpace(path)
                && path.IndexOfAny(Path.GetInvalidPathChars().ToArray()) == -1
                && Path.IsPathRooted(path)
                && !Path.GetPathRoot(path).Equals(Path.DirectorySeparatorChar.ToString(), StringComparison.Ordinal);
        }
    }
}