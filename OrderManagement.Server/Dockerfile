# Development stage (for hot-reloading)
FROM mcr.microsoft.com/dotnet/sdk:8.0 AS dev

# Install Visual Studio Debugger
RUN apt-get update && apt-get install -y curl unzip && \
    curl -sSL https://aka.ms/getvsdbgsh | bash /dev/stdin -v latest -l /remote_debugger && \
    apt-get clean && rm -rf /var/lib/apt/lists/*

WORKDIR /app

COPY ["OrderManagement.Server/OrderManagement.Server.csproj", "OrderManagement.Server/"]
COPY ["OrderManagement.Application/OrderManagement.Application.csproj", "OrderManagement.Application/"]
COPY ["OrderManagement.Infrastructure/OrderManagement.Infrastructure.csproj", "OrderManagement.Infrastructure/"]
COPY ["OrderManagement.Domain/OrderManagement.Domain.csproj", "OrderManagement.Domain/"]
RUN dotnet restore "./OrderManagement.Server/OrderManagement.Server.csproj"

EXPOSE 8080
EXPOSE 8081

ENTRYPOINT ["dotnet", "watch", "run", "--no-restore", "--no-launch-profile", "--project", "/app/OrderManagement.Server/OrderManagement.Server.csproj"]