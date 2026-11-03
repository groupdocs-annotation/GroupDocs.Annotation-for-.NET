# GroupDocs.Annotation for .NET Examples

This package contains C# Example Projects for [GroupDocs.Annotation for .NET](https://products.groupdocs.com/annotation/net) and sample input templates used in the examples.

<p align="center">
  <a title="Download complete GroupDocs.Annotation for .NET Example source code" href="https://github.com/groupdocs-annotation/GroupDocs.Annotation-for-.NET/archive/master.zip">
	<img src="https://raw.github.com/AsposeExamples/java-examples-dashboard/master/images/downloadZip-Button-Large.png" />
  </a>
</p>

The examples reference the [GroupDocs.Annotation](https://www.nuget.org/packages/GroupDocs.Annotation) package from NuGet:

* `GroupDocs.Annotation.Examples.CSharp.Net8`, `.Net6` and `.Net462` - SDK-style projects for .NET 8, .NET 6 and .NET Framework 4.6.2
* `GroupDocs.Annotation.Examples.CSharp.Framework` - classic .NET Framework project (packages.config)

## How to Run the Examples in Visual Studio?

Follow the given steps to proceed with project build:

* Extract the downloaded project and open the solution file in Visual Studio
* Right click on solution and press "Enable NuGet package Restore"
* Build the project

In other case, it is possible that Visual Studio is unable to automatically add APIs references due to Visual Studio version differences. In this case, please add references of missing APIs manually.

## How to Run the Examples in Docker container?

* Navigate into Examples directory
* Build an image
  `docker build --pull -t annotation:examples .`
* Run a container
  * Windows Command Line (CMD): `docker run --rm -it -v %cd%:/examples/Results annotation:examples`
  * Powershell: `docker run --rm -it -v ${PWD}:/examples/Results annotation:examples`
  * On Linux: `docker run --rm -it -v $(pwd):/examples/Results annotation:examples`

For more details, visit  [How to Run Examples](https://docs.groupdocs.com/display/annotationnet/How+to+Run+Examples).
