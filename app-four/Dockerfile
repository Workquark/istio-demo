# Build runtime image
FROM mcr.microsoft.com/dotnet/core/aspnet:3.1-alpine AS FINAL
WORKDIR /app
# Required for SQL SERVER for dotnet invariant issue - https://github.com/dotnet/SqlClient/issues/220
RUN apk add icu-libs 

COPY release .
RUN ls -al .
ENTRYPOINT ["dotnet", "./app-four.dll"]