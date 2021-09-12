#!/usr/bin/env bash

echo "Started build and run project script."

# Configure linux machine

# Explicitly setting DISPLAY=:0 is usually a way to access a machine's local display from outside the local session
export DISPLAY=:0

# Restore and build
dotnet restore
dotnet build --configuration Release

cd AvaRaspberry/bin/Release/net5.0/ || exit

# Create AppSettings config with Github Secrets
echo -e "$1" >> appsettings.json

# Run
( dotnet AvaRaspberry.dll & )
echo "Build and run project script is executed."

