FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["../Actio.Api/Actio.Api.csproj", "../Actio.Api/"]
RUN dotnet restore "../Actio.Api/Actio.Api.csproj"
COPY . .
WORKDIR "/src/../Actio.Api"
RUN dotnet build "Actio.Api.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Actio.Api.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Actio.Api.dll"]