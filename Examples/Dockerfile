# to build image run in PS - `docker build --pull -t annotation:examples .`
# to run tests run in PS - `docker run --rm -it -v ${PWD}:/examples/Results annotation:examples`

FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build_env

# prepare
WORKDIR /examples
COPY ./*.sln ./
COPY ./GroupDocs.Annotation.Examples.CSharp/ ./GroupDocs.Annotation.Examples.CSharp/
COPY ./GroupDocs.Annotation.Examples.CSharp.Net8/ ./GroupDocs.Annotation.Examples.CSharp.Net8/
# end prepare

# restore (the Linux SkiaSharp native-assets dependency is declared in the .csproj)
WORKDIR /examples
RUN dotnet restore ./GroupDocs.Annotation.Examples.CSharp.Net8/GroupDocs.Annotation.Examples.CSharp.Net8.csproj
# end restore

## build
WORKDIR /examples
RUN dotnet publish ./GroupDocs.Annotation.Examples.CSharp.Net8/GroupDocs.Annotation.Examples.CSharp.Net8.csproj --no-restore --configuration Debug -o ./../out
## end build

FROM mcr.microsoft.com/dotnet/runtime:8.0

# begin GroupDocs.Annotation native dependencies (System.Drawing / SkiaSharp on Linux)
RUN apt-get update && \
    DEBIAN_FRONTEND=noninteractive apt-get install -y libgdiplus libc6-dev libfontconfig1

# install Microsoft TrueType core fonts (the contrib component on Debian bookworm)
RUN sed -i 's/Components: main/Components: main contrib/' /etc/apt/sources.list.d/debian.sources && \
    echo "ttf-mscorefonts-installer msttcorefonts/accepted-mscorefonts-eula select true" | debconf-set-selections && \
    apt-get update && \
    DEBIAN_FRONTEND=noninteractive apt-get install -y ttf-mscorefonts-installer && \
    apt-get clean && \
    apt-get autoremove -y && \
    rm -rf /var/lib/apt/lists/*
# end GroupDocs.Annotation dependencies

WORKDIR /examples
COPY --from=build_env /examples/out .
ENTRYPOINT ["dotnet", "GroupDocs.Annotation.Examples.CSharp.Net8.dll"]
