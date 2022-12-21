using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetWebForms.Products.Common.Entity.Web;

namespace GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Entity.Request
{
    public class TextCoordinatesRequest : PostedDataEntity
    {
        public int pageNumber { get; set; }
    }
}