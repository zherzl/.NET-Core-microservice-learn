FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Actio.Services.Identity/Actio.Services.Identity.csproj", "Actio.Services.Identity/"]
RUN dotnet restore "Actio.Services.Identity/Actio.Services.Identity.csproj"
COPY . .
WORKDIR "/src/Actio.Services.Identity"
RUN dotnet build "Actio.Services.Identity.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Actio.Services.Identity.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Actio.Services.Identity.dll"]