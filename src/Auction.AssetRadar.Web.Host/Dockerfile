FROM mcr.microsoft.com/dotnet/sdk:8.0 AS build

WORKDIR /src
COPY ["src/Auction.AssetRadar.Web.Host/Auction.AssetRadar.Web.Host.csproj", "src/Auction.AssetRadar.Web.Host/"]
COPY ["src/Auction.AssetRadar.Web.Core/Auction.AssetRadar.Web.Core.csproj", "src/Auction.AssetRadar.Web.Core/"]
COPY ["src/Auction.AssetRadar.Application/Auction.AssetRadar.Application.csproj", "src/Auction.AssetRadar.Application/"]
COPY ["src/Auction.AssetRadar.Core/Auction.AssetRadar.Core.csproj", "src/Auction.AssetRadar.Core/"]
COPY ["src/Auction.AssetRadar.EntityFrameworkCore/Auction.AssetRadar.EntityFrameworkCore.csproj", "src/Auction.AssetRadar.EntityFrameworkCore/"]
WORKDIR "/src/src/Auction.AssetRadar.Web.Host"
RUN dotnet restore 

WORKDIR /src
COPY ["src/Auction.AssetRadar.Web.Host", "src/Auction.AssetRadar.Web.Host"]
COPY ["src/Auction.AssetRadar.Web.Core", "src/Auction.AssetRadar.Web.Core"]
COPY ["src/Auction.AssetRadar.Application", "src/Auction.AssetRadar.Application"]
COPY ["src/Auction.AssetRadar.Core", "src/Auction.AssetRadar.Core"]
COPY ["src/Auction.AssetRadar.EntityFrameworkCore", "src/Auction.AssetRadar.EntityFrameworkCore"]
WORKDIR "/src/src/Auction.AssetRadar.Web.Host"
RUN dotnet publish -c Release -o /publish --no-restore

FROM mcr.microsoft.com/dotnet/aspnet:8.0
EXPOSE 80
WORKDIR /app
COPY --from=build /publish .
ENTRYPOINT ["dotnet", "Auction.AssetRadar.Web.Host.dll"]
