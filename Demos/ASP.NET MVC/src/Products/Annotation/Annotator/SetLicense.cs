using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Annotator
{
    public class SetLicense
    {
        public void AddLicense(string licensePath)
        {
            License license = new License();
            license.SetLicense(licensePath);
        }
    }
}