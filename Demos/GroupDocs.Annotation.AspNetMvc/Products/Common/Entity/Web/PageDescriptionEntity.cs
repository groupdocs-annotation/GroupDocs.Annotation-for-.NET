using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace GroupDocs.Annotation.AspNetMvc.Products.Common.Entity.Web
{
    public class PageDescriptionEntity
    {
        public double width { get; set; }
        public double height { get; set; }
        public int number { get; set; }
        public int angle { get; set; }

        [JsonProperty]
        private string data;

        public void SetData(string data)
        {
            this.data = data;
        }

        public string GetData()
        {
            return data;
        }
    }
}