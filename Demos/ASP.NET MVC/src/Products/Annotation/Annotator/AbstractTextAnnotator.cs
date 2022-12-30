using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GroupDocs.Annotation.AspNetMvc.Products.Annotation.Entity.Web;
using GroupDocs.Annotation.Models;

namespace GroupDocs.Annotation.AspNetMvc.Products.Annotation.Annotator
{
    public abstract class AbstractTextAnnotator : BaseAnnotator
    {
        protected AbstractTextAnnotator(AnnotationDataEntity annotationData, PageInfo pageInfo)
            : base(annotationData, pageInfo)
        {

        }
        protected static List<Point> GetPoints(AnnotationDataEntity annotationData, PageInfo pageInfo)
        {
            return new List<Point>
            {
                new Point((int) annotationData.left, (int) (pageInfo.Height - annotationData.top)),
                new Point((int) (annotationData.left + annotationData.width), (int) (pageInfo.Height - annotationData.top)),
                new Point((int) annotationData.left, (int) (pageInfo.Height - annotationData.top - annotationData.height)),
                new Point((int) (annotationData.left + annotationData.width), (int) (pageInfo.Height - annotationData.top - annotationData.height))
            };
        }

        protected static List<Point> GetPointsForImages(AnnotationDataEntity annotationData, PageInfo pageInfo)
        {
            return new List<Point>
            {
                new Point((int) annotationData.left, (int) (annotationData.top + annotationData.height)),
                new Point((int) (annotationData.left + annotationData.width), (int) (annotationData.top + annotationData.height)),
                new Point((int) annotationData.left, (int) annotationData.top),
                new Point((int) (annotationData.left + annotationData.width), (int) annotationData.top)
            };
        }
    }
}