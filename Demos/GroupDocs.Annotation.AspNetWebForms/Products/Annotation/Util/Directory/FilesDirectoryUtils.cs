using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Config;
using GroupDocs.Annotation.AspNetWebForms.Products.Common.Util.Directory;

namespace GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Util.Directory
{
    public class FilesDirectoryUtils : IDirectoryUtils
    {

        private readonly AnnotationConfiguration AnnotationConfiguration;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="signatureConfiguration">SignatureConfiguration</param>
        public FilesDirectoryUtils(AnnotationConfiguration annotationConfiguration)
        {
            AnnotationConfiguration = annotationConfiguration;
        }

        /// <summary>
        /// Get path
        /// </summary>
        /// <returns>string</returns>
        public string GetPath()
        {
            return AnnotationConfiguration.GetFilesDirectory();
        }
    }
}