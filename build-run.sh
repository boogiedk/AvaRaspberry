#!/usr/bin/env bash

echo "Start application build"
cd AvaRaspberry/ && dotnet build
echo "Start application run"
dotnet run
