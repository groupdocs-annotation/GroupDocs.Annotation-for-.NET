using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetMvc.Products.Common.Entity.Web;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Entity.Web
{
    public class AnnotatedDocumentEntity : PageDescriptionEntity
    {
        public string guid { get; set; }
        public List<PageDataDescriptionEntity> pages { get; set; } = new List<PageDataDescriptionEntity>();
        public string[] supportedAnnotations { get; set; }
    }
}