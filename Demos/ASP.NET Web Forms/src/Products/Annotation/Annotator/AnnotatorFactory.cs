using System;
using System.Collections.Generic;
using GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Entity.Web;
using GroupDocs.Annotation.Models;

namespace GroupDocs.Annotation.AspNetWebForms.Products.Annotation.Annotator
{
    public static class AnnotatorFactory
    {
        /// <summary>
        /// Create annotator instance depending on type of annotation
        /// </summary>
        /// <param name="annotationData">AnnotationDataEntity</param>
        /// <param name="pageInfo">PageInfo</param>
        /// <returns></returns>
        public static BaseAnnotator createAnnotator(AnnotationDataEntity annotationData, PageInfo pageInfo)
        {
            AnnotationDataEntity roundedAnnotationData = RoundCoordinates(annotationData);
            switch (roundedAnnotationData.type)
            {
                case "textHighlight":
                    return new TextHighlightAnnotator(roundedAnnotationData, pageInfo);
                case "area":
                    return new AreaAnnotator(roundedAnnotationData, pageInfo);
                case "point":
                    return new PointAnnotator(roundedAnnotationData, pageInfo);
                case "textStrikeout":
                    return new TextStrikeoutAnnotator(roundedAnnotationData, pageInfo);
                case "polyline":
                    return new PolylineAnnotator(roundedAnnotationData, pageInfo);
                case "textField":
                    return new TextFieldAnnotator(roundedAnnotationData, pageInfo);
                case "watermark":
                    return new WatermarkAnnotator(roundedAnnotationData, pageInfo);
                case "textReplacement":
                    return new TextReplacementAnnotator(roundedAnnotationData, pageInfo);
                case "arrow":
                    return new ArrowAnnotator(roundedAnnotationData, pageInfo);
                case "textRedaction":
                    return new TextRedactionAnnotator(roundedAnnotationData, pageInfo);
                case "resourcesRedaction":
                    return new ResourceRedactionAnnotator(roundedAnnotationData, pageInfo);
                case "textUnderline":
                    return new TextUnderlineAnnotator(roundedAnnotationData, pageInfo);
                case "distance":
                    return new DistanceAnnotator(roundedAnnotationData, pageInfo);
                default:
                    throw new ArgumentNullException("Wrong annotation data without annotation type!");
            }
        }

        private static AnnotationDataEntity RoundCoordinates(AnnotationDataEntity annotationData)
        {
            annotationData.height = (float)Math.Round(annotationData.height, 0);
            annotationData.left = (float)Math.Round(annotationData.left, 0);
            annotationData.top = (float)Math.Round(annotationData.top, 0);
            annotationData.width = (float)Math.Round(annotationData.width, 0);
            return annotationData;
        }
    }
}