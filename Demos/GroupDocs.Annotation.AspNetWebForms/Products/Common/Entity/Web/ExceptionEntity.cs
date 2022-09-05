using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Annotation.AspNetWebForms.Products.Common.Entity.Web
{
    public class ExceptionEntity
    {
        public string message { get; set; }
        public System.Exception exception { get; set; }
    }
}