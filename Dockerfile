# Use a imagem oficial da Microsoft para ASP.NET Core runtime
FROM mcr.microsoft.com/dotnet/aspnet:6.0 AS base
WORKDIR /app
EXPOSE 80

# Use a imagem SDK para construir o app
FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /src
COPY ["AplicadorQuestoesArcoIrisV2/AplicadorQuestoesArcoIrisV2.csproj", "AplicadorQuestoesArcoIrisV2/"]
RUN dotnet restore "AplicadorQuestoesArcoIrisV2/AplicadorQuestoesArcoIrisV2.csproj"
COPY . .
WORKDIR "/src/AplicadorQuestoesArcoIrisV2"
RUN dotnet build "AplicadorQuestoesArcoIrisV2.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "AplicadorQuestoesArcoIrisV2.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "AplicadorQuestoesArcoIrisV2.dll"]
