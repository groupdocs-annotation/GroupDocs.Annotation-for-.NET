namespace GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Annotator
{
    public class SetLicense
    {
        public void Set_License(string licensePath)
        {
            License license = new License();
            license.SetLicense(licensePath);
        }
    }
}