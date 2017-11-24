FROM microsoft/dotnet:2.0-sdk AS build-env
COPY ./app /virtual-app
WORKDIR /virtual-app
RUN dotnet restore
RUN dotnet publish -c Release -o publish-folder -r linux-x64
# build runtime image
FROM microsoft/dotnet:2.0-runtime 
COPY --from=build-env /virtual-app/publish-folder ./
ENV ASPNETCORE_URLS=http://*:1905
EXPOSE 1905
ENTRYPOINT ["dotnet", "app.dll"]