#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Travel.Discover/Travel.Discover.csproj", "Travel.Discover/"]
RUN dotnet restore "Travel.Discover/Travel.Discover.csproj"
COPY . .
WORKDIR "/src/Travel.Discover"
RUN dotnet build "Travel.Discover.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Travel.Discover.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Travel.Discover.dll"]