using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetMvc.Products.Common.Entity.Web;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Entity.Request
{
    public class TextCoordinatesRequest : PostedDataEntity
    {
        public int pageNumber { get; set; }
    }
}