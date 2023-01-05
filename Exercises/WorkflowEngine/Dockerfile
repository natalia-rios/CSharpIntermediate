FROM mcr.microsoft.com/dotnet/runtime:7.0 AS base
WORKDIR /app

FROM mcr.microsoft.com/dotnet/sdk:7.0 AS build
WORKDIR /src
COPY ["WorkflowEngine/WorkflowEngine.csproj", "WorkflowEngine/"]
RUN dotnet restore "WorkflowEngine/WorkflowEngine.csproj"
COPY . .
WORKDIR "/src/WorkflowEngine"
RUN dotnet build "WorkflowEngine.csproj" -c Release -o /app/build

FROM build AS publish
RUN dotnet publish "WorkflowEngine.csproj" -c Release -o /app/publish

FROM base AS final
WORKDIR /app
COPY --from=publish /app/publish .
ENTRYPOINT ["dotnet", "WorkflowEngine.dll"]
