# https://hub.docker.com/_/microsoft-dotnet
FROM mcr.microsoft.com/dotnet/sdk:5.0-focal AS build
WORKDIR /source

# copy csproj and restore as distinct layers
COPY *.sln .
COPY MvcMusic/*.csproj ./MvcMusic/
RUN dotnet restore -r linux-x64

# copy everything else and build app
COPY MvcMusic/. ./MvcMusic/
WORKDIR /source/MvcMusic
RUN dotnet publish -c release -o /app -r linux-x64 --self-contained false --no-restore

# sql migration
RUN dotnet tool install --global dotnet-ef && export PATH="$PATH:/root/.dotnet/tools" && dotnet ef database update

# final stage/image
FROM mcr.microsoft.com/dotnet/aspnet:5.0-focal-amd64
WORKDIR /app
COPY --from=build /app ./
ENTRYPOINT ["./MvcMusic"]