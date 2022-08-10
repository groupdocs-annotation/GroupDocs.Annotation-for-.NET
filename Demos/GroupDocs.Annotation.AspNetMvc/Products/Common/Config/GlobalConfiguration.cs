using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetMvc.Products.Annotation.Config;

namespace GroupDocs.Annotation.AspNetMvc.Products.Common.Config
{
    public class GlobalConfiguration
    {
        public ServerConfiguration Server { get; set; }
        public ApplicationConfiguration Application { get; set; }
        public CommonConfiguration Common { get; set; }
        public AnnotationConfiguration Annotation { get; set; }

        /// <summary>
        /// Get all configurations
        /// </summary>
        public GlobalConfiguration()
        {
            Server = new ServerConfiguration();
            Application = new ApplicationConfiguration();
            Common = new CommonConfiguration();
            Annotation = new AnnotationConfiguration();
        }
    }
}