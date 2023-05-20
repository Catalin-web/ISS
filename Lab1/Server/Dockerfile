# BUILD
FROM mcr.microsoft.com/dotnet/sdk:6.0-focal AS builder

COPY Server/ /app/Server/

WORKDIR /app/Server

RUN dotnet publish -c Release --runtime ubuntu.20.04-x64 --self-contained true Server.WebApi/Server.WebApi.csproj

# RUN
FROM ubuntu:20.04

WORKDIR /app

RUN apt-get update && apt-get install -y wget
RUN apt-get update && apt-get install -y apt-transport-https
RUN apt-get update && apt-get install -y libssl1.1 ca-certificates

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1

COPY --from=builder /app/Server/Server.WebApi/bin/Release/net6.0/ubuntu.20.04-x64/publish/* /app/

EXPOSE 12500
CMD ["/app/Server.WebApi"]

ENV DOTNET_SYSTEM_GLOBALIZATION_INVARIANT=1
## Required to turn off dotnet telemetry which writes to /tmp per https://github.com/dotnet/docs/issues/10217.
ENV COMPlus_EnableDiagnostics=0