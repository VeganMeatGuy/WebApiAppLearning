FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS runtime
WORKDIR /app
COPY published/ ./
EXPOSE 8080
ENTRYPOINT ["dotnet", "WebApiTestApp.dll"]