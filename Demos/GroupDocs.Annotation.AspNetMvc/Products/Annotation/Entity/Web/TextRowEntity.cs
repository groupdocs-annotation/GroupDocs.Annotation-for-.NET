using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Entity.Web
{
    public class TextRowEntity
    {
        public List<double> textCoordinates { get; set; }
        public double lineTop { get; set; }
        public double lineHeight { get; set; }
    }
}