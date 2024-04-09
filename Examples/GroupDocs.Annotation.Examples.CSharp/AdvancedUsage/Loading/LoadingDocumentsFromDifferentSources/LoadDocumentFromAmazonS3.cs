#if !NETCOREAPP

using System;
using System.IO;

namespace GroupDocs.Annotation.Examples.CSharp.AdvancedUsage.Loading
{
    using Amazon.S3;
    using Amazon.S3.Model;
    
    using GroupDocs.Annotation;
    using GroupDocs.Annotation.Models;
    using GroupDocs.Annotation.Models.AnnotationModels;

    /// <summary>
    /// This example demonstrates loading document from Amazon S3 storage.
    /// </summary>
    class LoadDocumentFromAmazonS3
    {
        public static void Run()
        {
            Console.WriteLine("\n--------------------------------------------------------------------------------------------------");
            Console.WriteLine("[Example Advanced Usage] # LoadDocumentFromAmazonS3 : loading document from Amazon S3 storage");

            string outputPath = Path.Combine(Constants.GetOutputDirectoryPath(), "result" + Path.GetExtension(Constants.INPUT));

            string key = "sample.pdf";
            using (Annotator annotator = new Annotator(DownloadFile(key)))
            {
                AreaAnnotation area = new AreaAnnotation()
                {
                    Box = new Rectangle(100, 100, 100, 100),
                    BackgroundColor = 65535,
                };
                annotator.Add(area);
                annotator.Save(outputPath);
            }
            Console.WriteLine($"\nDocument saved successfully.\nCheck output in {outputPath}.");
        }

        private static Stream DownloadFile(string key)
        {
            AmazonS3Client client = new AmazonS3Client();
            string bucketName = "my-bucket";
            GetObjectRequest request = new GetObjectRequest
            {
                Key = key,
                BucketName = bucketName
            };
            using (GetObjectResponse response = client.GetObject(request))
            {
                MemoryStream stream = new MemoryStream();
                response.ResponseStream.CopyTo(stream);
                stream.Position = 0;
                return stream;
            }
        }
    }
}
#endif