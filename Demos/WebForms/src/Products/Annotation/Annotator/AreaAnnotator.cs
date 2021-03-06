﻿using GroupDocs.Annotation.Models;
using GroupDocs.Annotation.Models.AnnotationModels;
using GroupDocs.Annotation.WebForms.Products.Annotation.Entity.Web;
using GroupDocs.Annotation.Options;
using System;

namespace GroupDocs.Annotation.WebForms.Products.Annotation.Annotator
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
            throw new NotSupportedException(String.Format(Message, annotationData.type));
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