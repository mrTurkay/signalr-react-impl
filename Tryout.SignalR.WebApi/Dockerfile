#See https://aka.ms/containerfastmode to understand how Visual Studio uses this Dockerfile to build your images for faster debugging.

FROM mcr.microsoft.com/dotnet/aspnet:5.0 AS base
WORKDIR /app
EXPOSE 80
EXPOSE 443

FROM mcr.microsoft.com/dotnet/sdk:5.0 AS build
WORKDIR /src
COPY ["Tryout.SignalR.WebApi.csproj", "."]
RUN dotnet restore "./Tryout.SignalR.WebApi.csproj"
COPY . .
WORKDIR "/src/."
RUN dotnet build "Tryout.SignalR.WebApi.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Tryout.SignalR.WebApi.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Tryout.SignalR.WebApi.dll"]