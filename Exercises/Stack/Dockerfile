FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Exercises/Exercises.csproj", "Exercises/"]
RUN dotnet restore "Exercises/Exercises.csproj"
COPY . .
WORKDIR "/src/Exercises"
RUN dotnet build "Exercises.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Exercises.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Exercises.dll"]
