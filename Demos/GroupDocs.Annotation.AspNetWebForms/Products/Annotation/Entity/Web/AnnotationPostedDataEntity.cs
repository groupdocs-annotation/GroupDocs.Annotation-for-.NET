using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetWebForms.Products.Common.Entity.Web;

namespace GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Entity.Web
{
    public class AnnotationPostedDataEntity : PostedDataEntity
    {
        public string documentType { get; set; }
        public AnnotationDataEntity[] annotationsData { get; set; }
        public bool print { get; set; }
    }
}