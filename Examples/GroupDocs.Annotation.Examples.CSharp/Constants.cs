using System.IO;
using System.Runtime.CompilerServices;

namespace GroupDocs.Annotation.Examples.CSharp
{
    internal static class Constants
    {

        public const string LicensePath =  "./Resources/GroupDocs.Annotation.lic";
        public const string SamplesPath = "./Resources/SampleFiles";
        public const string FontsPath = "./Resources/Fonts";
        public const string OutputPath = "./Results/Output/";
        public static string INPUT_PDF => GetSampleFilePath("input.pdf");
        public static string INPUT_DOCX => GetSampleFilePath("input.docx");
        public static string INPUT_ZINDEX => GetSampleFilePath("input_zIndex.docx");
        public static string INPUT_WITH_CUSTOM_FONT => GetSampleFilePath("inputWithCustomFont.pdf"); 
        public static string ANNOTATED_WITH_REPLIES => GetSampleFilePath("annotated_with_replies.pdf");
        public static string PICTURE => GetSampleFilePath("google.png");
        public static string INPUT_PROTECTED => GetSampleFilePath("input_protected.pdf");
        public static string ANNOTATED_WITH_VERSIONS => GetSampleFilePath("annotated_with_versions.pdf");
        public static string RESULT => GetSampleFilePath("result.pdf");
        public static string ANNOTATED => GetSampleFilePath("annotated.pdf");
        public static string ANNOTATED_DOCX => GetSampleFilePath("annotated.docx");
        public static string CELLS_INPUT => GetSampleFilePath("input.xlsx");

        private static string GetSampleFilePath(string filePath, [CallerFilePath] string callerFilePath = null)
        {
            DirectoryInfo pathInfo = Directory.GetParent(callerFilePath);
            return Path.Combine(pathInfo + SamplesPath, filePath);
        }

        internal static string GetFontDirectory([CallerFilePath] string callerFilePath = null)
        {
            DirectoryInfo pathInfo = Directory.GetParent(callerFilePath);
            return Path.Combine(pathInfo + FontsPath);
        }

        public static string GetOutputDirectoryPath([CallerFilePath] string callerFilePath = null)
        {
            string outputDirectory = Path.Combine(OutputPath, Path.GetFileNameWithoutExtension(callerFilePath));
            if (!Directory.Exists(outputDirectory))
                Directory.CreateDirectory(outputDirectory);

            string path = Path.GetFullPath(outputDirectory);
            return path;
        }
    }
}