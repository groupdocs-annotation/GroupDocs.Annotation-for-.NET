using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Annotation.AspNetWebForms.Products.Common.Entity.Web
{
    public class FileDescriptionEntity
    {
        public string guid { get; set; }
        public string name { get; set; }
        public string docType { get; set; }
        public bool isDirectory { get; set; }
        public long size { get; set; }
    }
}