using GroupDocs.Annotation.AspNetMvc.Products.Annotation.Annotator;
using GroupDocs.Annotation.AspNetMvc.Products.Annotation.Entity.Web;
using GroupDocs.Annotation.Models;
using GroupDocs.Annotation.Models.AnnotationModels;
using GroupDocs.Annotation.Options;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Annotator
{
    public class AreaAnnotator : BaseAnnotator
    {
        private AreaAnnotation areaAnnotation;

        public AreaAnnotator(AnnotationDataEntity annotationData, PageInfo pageInfo)
            : base(annotationData, pageInfo)
        {
            areaAnnotation = new AreaAnnotation
            {
                Box = GetBox()
            };
        }

        public override AnnotationBase AnnotateWord()
        {
            areaAnnotation = InitAnnotationBase(areaAnnotation) as AreaAnnotation;
            return areaAnnotation;
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
            return AnnotationType.Area;
        }
    }
}