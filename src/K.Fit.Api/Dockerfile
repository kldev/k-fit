FROM mcr.microsoft.com/dotnet/aspnet:6.0 as run

WORKDIR /app
RUN apt-get update
RUN apt-get install -qq curl
RUN ls -la
ENV ASPNETCORE_ENVIRONMENT Docker 
ENV ASPNETCORE_URLS http://*:80


FROM mcr.microsoft.com/dotnet/sdk:6.0 AS build
WORKDIR /build

COPY *.csproj .
RUN  dotnet restore

COPY . .

RUN ls -la

RUN dotnet publish -c release -o /build/out
RUN ls -la /build/out

FROM run
COPY --from=build /build/out .

EXPOSE 80
ENTRYPOINT ["dotnet", "K.Fit.Api.dll"]