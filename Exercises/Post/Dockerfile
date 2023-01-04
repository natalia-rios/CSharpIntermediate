FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["Post/Post.csproj", "Post/"]
RUN dotnet restore "Post/Post.csproj"
COPY . .
WORKDIR "/src/Post"
RUN dotnet build "Post.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "Post.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "Post.dll"]
