#!/bin/bash

dotnet build iDotnet.sln


bash -c "dotnet run --project ./app-four/app-four.csproj"
bash -c "dotnet run --project ./app-one/app-one.csproj"
bash -c "dotnet run --project ./app-three/app-three.csproj"
bash -c "dotnet run --project ./app-two/app-two.csproj"