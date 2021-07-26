![Nuget](https://img.shields.io/nuget/v/groupdocs.annotation) ![Nuget](https://img.shields.io/nuget/dt/groupdocs.annotation) ![GitHub](https://img.shields.io/github/license/groupdocs-annotation/GroupDocs.Annotation-for-.NET)

## .NET API for Document Annotation

GroupDocs.Annotation for .NET is a lightweight, yet powerful .NET library that seamlessly [integrates document annotation features](https://products.groupdocs.com/annotation/net) into your .NET applications. Apply graphic, text and watermark annotations on Office, OpenOffice, PDF documents as well as images & CAD drawings with simplest object model.

<p align="center">
  <a title="Download complete GroupDocs.Annotation for .NET source code" href="https://github.com/groupdocs-annotation/GroupDocs.Annotation-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

Directory | Description
--------- | -----------
[Demos](https://github.com/groupdocs-annotation/GroupDocs.Annotation-for-.NET/tree/master/Demos)  | GroupDocs.Annotation for .NET Demo projects.
[Examples](https://github.com/groupdocs-annotation/GroupDocs.Annotation-for-.NET/tree/master/Examples)  | Contains the package of all .NET C# examples and sample files that will help you learn how to use product features.

## Annotate Documents & Images via .NET Library

- Import document annotations.
- Add, remove or reply to annotation comments.
- Export annotated document back to its original format.
- Render document pages as images.
- Generate document thumbnails or document image preview.
- Support for local cache or custom cache (Amazon S3, Dropbox etc.).
- [Get list](https://docs.groupdocs.com/display/annotationnet/Get+supported+file+formats) of [supported file formats](https://docs.groupdocs.com/display/annotationnet/Supported+Document+Formats).
- Fetch document information, such as, page count & file size.
- [Extract annotations from a document](https://docs.groupdocs.com/display/annotationnet/Extract+annotations+from+document) and serialize to XML format.
- Remove previously added annotations from a document.
- Update specific annotation properties (size, color etc.).

## Microsoft Office Formats

**Microsoft Word:** DOC, DOCM, DOCX, DOT, DOTM, DOTX, RTF\
**Microsoft Excel:** XLS, XLSB, XLSM, XLSX\
**Microsoft PowerPoint:** PPT, PPTX, PPSX, PPS\
**Microsoft Visio:** VSD, VSDX, VSS, VST

## Other Document Formats

**Portable:** PDF (PDF/A-1a, PDF/A-1b, PDF/A-2a)\
**OpenDocument:** ODT, ODS, ODP\
**Images:** TIF, TIFF, JPG, JPEG, PNG, BMP\
**AutoCAD:** DWG, DXF\
**Email:** EML\
**Web:** HTML\
**Others:** DCM

## Annotation Objects

**Graphic Annotation:** Area, Arrow, Distance, Ellipse, Point, Polyline, Resource Redaction, TextField
**Text Annotation:** Highlight, Link, Replacement, Strikeout, Reduction, Underline
**Watermark:** Diagonal, Horizontal

## Develop & Deploy GroupDocs.Annotation Anywhere

**Frameworks:** NET Standard 2.0, .NET Framework 2.0 or higher, .NET Core 2.0 or higher, Mono Framework 1.2 or higher\
**Operating Systems:** Linux, Mac OS X, Windows Desktop (x86 & x64), Windows Server (x86 & x64), Windows Azure\
**Development Environments:** Microsoft Visual Studio, Xamarin.Android, Xamarin.IOS, Xamarin.Mac, MonoDevelop

## Getting Started with GroupDocs.Annotation for .NET

Are you ready to give GroupDocs.Annotation for .NET a try? Simply execute `Install-Package GroupDocs.Annotation` from Package Manager Console in Visual Studio to fetch & reference GroupDocs.Annotation assembly in your project. If you already have GroupDocs.Annotation for .Net and want to upgrade it, please execute `Update-Package GroupDocs.Annotation` to get the latest version.

## Use C# Code to Save Annotated PDF Pages

```csharp
// for this example input file ("input.pdf") must have at least 10 pages
using (Annotator annotator = new Annotator(“input.pdf”))
{
    AreaAnnotation area = new AreaAnnotation()
    {
        Box = new Rectangle(100, 100, 100, 100),
        BackgroundColor = 65535,
        PageNumber = 1
    };
    EllipseAnnotation ellipse = new EllipseAnnotation()
    {
        Box = new Rectangle(100, 100, 100, 100),
        BackgroundColor = 123456,
        PageNumber = 9
    };
    annotator.Add(new List<AnnotationBase>() { area, ellipse });
    annotator.Save(“result.pdf” new SaveOptions { OnlyAnnotatedPages = true});
}
```

[Home](https://www.groupdocs.com/) | [Product Page](https://products.groupdocs.com/annotation/net) | [Documentation](https://docs.groupdocs.com/display/annotationnet/Home) | [API Reference](https://apireference.groupdocs.com/net/annotation) | [Examples](https://github.com/groupdocs-annotation/GroupDocs.Annotation-for-.NET) | [Blog](https://blog.groupdocs.com/category/annotation/) | [Free Support](https://forum.groupdocs.com/c/annotation) | [Temporary License](https://purchase.groupdocs.com/temporary-license)
