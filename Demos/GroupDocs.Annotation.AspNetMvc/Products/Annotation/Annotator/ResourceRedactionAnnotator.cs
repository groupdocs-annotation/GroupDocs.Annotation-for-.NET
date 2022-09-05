using GroupDocs.Annotation.AspNetMvc.Products.Annotation.Entity.Web;
using GroupDocs.Annotation.Models;
using GroupDocs.Annotation.Models.AnnotationModels;
using GroupDocs.Annotation.Options;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Annotator
{
    public class ResourceRedactionAnnotator : BaseAnnotator
    {
        private ResourcesRedactionAnnotation resourcesRedactionAnnotation;

        public ResourceRedactionAnnotator(AnnotationDataEntity annotationData, PageInfo pageInfo)
            : base(annotationData, pageInfo)
        {
            this.resourcesRedactionAnnotation = new ResourcesRedactionAnnotation
            {
                Box = GetBox()
            };
        }

        public override AnnotationBase AnnotateWord()
        {
            resourcesRedactionAnnotation = InitAnnotationBase(resourcesRedactionAnnotation) as ResourcesRedactionAnnotation;
            return resourcesRedactionAnnotation;
        }

        public override AnnotationBase AnnotatePdf()
        {
            return AnnotateWord();
        }

        public override AnnotationBase AnnotateCells()
        {
            return AnnotateWord();
        }

        public override AnnotationBase AnnotateSlides()
        {
            return AnnotateWord();
        }

        public override AnnotationBase AnnotateImage()
        {
            return AnnotateWord();
        }

        public override AnnotationBase AnnotateDiagram()
        {
            return AnnotateWord();
        }

        protected override AnnotationType GetType()
        {
            return AnnotationType.ResourcesRedaction;
        }
    }
}