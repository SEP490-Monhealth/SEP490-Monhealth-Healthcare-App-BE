# Use the official Microsoft ASP.NET Core runtime as a base image
FROM mcr.microsoft.com/dotnet/aspnet:8.0 AS base
WORKDIR /app
EXPOSE 8080

# Use the official Microsoft .NET SDK as a build image
FROM mcr.microsoft.com/dotnet/sdk:8.0.401-1-alpine3.20-amd64 AS build
WORKDIR /app/src

# Copy the solution file and restore dependencies
COPY ["Monhealth.Api/Monhealth.Api.csproj", "Monhealth.Api/"]
COPY ["Monhealth.Application/Monhealth.Application.csproj", "Monhealth.Application/"]
COPY ["Monhealth.Core/Monhealth.Domain.csproj", "Monhealth.Core/"]
COPY ["Monhealth.Identity/Monhealth.Identity.csproj", "Monhealth.Identity/"]
COPY ["Monhealth.Infrastructure/Monhealth.Infrastructure.csproj", "Monhealth.Infrastructure/"]

# Restore the dependencies
RUN dotnet restore "Monhealth.Api/Monhealth.Api.csproj"
# Copy the rest of the project files and build the project
COPY . /app/src

# Build the project
WORKDIR /app/src
RUN dotnet build

# Publish the project
FROM build AS publish
WORKDIR /app/src/Monhealth.Api
RUN dotnet publish Monhealth.Api.csproj -c Release --no-restore -o /app/publish

# Create a new image from the ASP.NET Core runtime image
FROM base AS final
WORKDIR /app/src
COPY --from=publish /app/publish .

# Define the entry point for the container
ENTRYPOINT ["dotnet", "Monhealth.Api.dll"]