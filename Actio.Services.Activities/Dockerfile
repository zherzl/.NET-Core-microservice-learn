FROM mcr.microsoft.com/dotnet/core/aspnet:2.2-stretch-slim AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/core/sdk:2.2-stretch AS build
WORKDIR /src
COPY ["Actio.Services.Activities/Actio.Services.Activities.csproj", "Actio.Services.Activities/"]
RUN dotnet restore "Actio.Services.Activities/Actio.Services.Activities.csproj"
COPY . .
WORKDIR "/src/Actio.Services.Activities"
RUN dotnet build "Actio.Services.Activities.csproj" -c Release -o /app

FROM build AS publish
RUN dotnet publish "Actio.Services.Activities.csproj" -c Release -o /app

FROM base AS final
WORKDIR /app
COPY --from=publish /app .
ENTRYPOINT ["dotnet", "Actio.Services.Activities.dll"]